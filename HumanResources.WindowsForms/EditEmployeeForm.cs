using FluentValidation.Results;
using HumanResources.Entities;
using HumanResources.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResources.WindowsForms
{
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        private readonly int employeeId;
        private readonly IPersonalRepository repository;

        private Employee employee;

        public EditEmployeeForm(IPersonalRepository repository, int id):this()
        {
            this.repository = repository;
            this.employeeId = id;
        }

        void ShowEmployee()
        {
            this.ShowEntity(this.employee);
        }

        void UpdateEmployee()
        {
            this.UpdateEntityFromControls(this.employee);
        }


        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            if (employeeId == 0) this.employee = new Employee();
            else employee = repository.Get(employeeId);
            ShowEmployee();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
            var validationResults = employee.Validate();
            if (validationResults.IsValid)
            {
                this.repository.Save(employee);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            ShowErrors(validationResults);
        }

        void ShowErrors(ValidationResult validationResults)
        {
            foreach (var pi in typeof(Employee).GetProperties())
            {
                var controlProperty = this.GetType().GetField(pi.Name + "Control", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (controlProperty != null)
                {
                    this.errorProvider.SetError((Control)controlProperty.GetValue(this), 
                        string.Join(", ", validationResults.Errors.Where(x => x.PropertyName == pi.Name)
                        .Select(x => x.ErrorMessage)));
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.repository.Reload(this.employee);
            this.Close();
        }
    }
}
