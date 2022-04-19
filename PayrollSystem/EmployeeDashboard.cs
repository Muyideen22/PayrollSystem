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
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void UpdteDetailsbutton_Click(object sender, EventArgs e)
        {
            this.EmployeeHomeTab.SelectedTab = this.DetailsTab;
        }

        private void AddAttendancebutton_Click(object sender, EventArgs e)
        {
            this.EmployeeHomeTab.SelectedTab = this.attendanceTab;

        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            this.EmployeeHomeTab.SelectedTab = this.LeaveTab;

        }
    }
}
