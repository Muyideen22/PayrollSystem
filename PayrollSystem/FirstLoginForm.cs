using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class FirstLoginForm : Form
    {
        public FirstLoginForm()
        {
            InitializeComponent();
        }

        private void Employeebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLoginForm employeeLoginForm = new();
            employeeLoginForm.Show();
        }

        private void Adminbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm adminlogin = new();
            adminlogin.Show();
        }
    }
}
