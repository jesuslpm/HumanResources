using HumanResources.Entities;
using HumanResources.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResources.WindowsForms
{
    public partial class PersonalForm : Form
    {
        public PersonalForm()
        {
            InitializeComponent();
        }

        private readonly IPersonalRepository repository;

        public PersonalForm(IPersonalRepository personalRepository):this()
        {
            this.repository = personalRepository;
        }

        private void LoadPersonal()
        {
            var personal = this.repository.GetMinimalList();
            this.personalBindingSource.DataSource = personal;
        }

        private void PersonalForm_Load(object sender, EventArgs e)
        {
            LoadPersonal();
        }

        private EmployeeMinimal Current
        {
            get
            {
                return (EmployeeMinimal) this.personalBindingSource.Current;
            }
        }

        private void EditEmployee(int id)
        {
            using (var from = new EditEmployeeForm(this.repository, id))
            {
                var result = from.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadPersonal();
                }
            }
        }

        private void employeesGrid_DoubleClick(object sender, EventArgs e)
        {
            EditEmployee(Current.Id);
        }



        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            EditEmployee(0);
        }
    }
}
