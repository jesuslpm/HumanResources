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

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            if (employeeId == 0) this.employee = new Employee();
            else employee = repository.Get(employeeId);
            this.ShowEntity(this.employee);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.UpdateEntityFromControls(this.employee);
            var validationResults = employee.Validate();
            if (validationResults.IsValid)
            {
                this.repository.Save(employee);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            this.ShowErrors(this.errorProvider, typeof(Employee), validationResults);
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (this.employee.Id != 0)
            {
                this.repository.Reload(this.employee);
            }
            this.Close();
        }
    }
}
