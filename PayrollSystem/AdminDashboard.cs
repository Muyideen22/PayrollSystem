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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addEmployeebutton_Click(object sender, EventArgs e)
        {
            this.homeTab.SelectedTab = this.AddEmployeeTab;
        }

        private void ViewEmployeesbutton_Click(object sender, EventArgs e)
        {
            this.homeTab.SelectedTab = this.ViewEmployeesTab;
        }

        private void addPaygradeButton_Click(object sender, EventArgs e)
        {
            this.homeTab.SelectedTab = this.addPayGradeTab;
        }

        private void ViewPayGradesbutton_Click(object sender, EventArgs e)
        {
            this.homeTab.SelectedTab = this.viewPayGradeTab;
        }

        private void PayrollButton_Click(object sender, EventArgs e)
        {
            this.homeTab.SelectedTab = this.payRollInfoTab;
        }
    }
}
