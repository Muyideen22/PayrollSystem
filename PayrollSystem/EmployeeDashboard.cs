using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            GetEmployeeDetails();
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

        private void SaveLeavebutton_Click(object sender, EventArgs e)
        {
            string reason = ReasontextBox.Text;
            DateTime _startDate = startDate.Value;
            DateTime _endDate = endDate.Value;

            DatabaseConnectionWrapper databaseConnectionWrapper = new DatabaseConnectionWrapper();
            if (databaseConnectionWrapper != null)
            {
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"
                                INSERT INTO LEAVEREQUEST (EMPLOYEEID, STARTDATE, ENDDATE, REASON)
                                values(@emp_id, @start,@end, @reason);";

                    command.Parameters.AddWithValue("@emp_id", this.EmployeeID);
                    command.Parameters.AddWithValue("@start", _startDate);
                    command.Parameters.AddWithValue("@end", _endDate);
                    command.Parameters.AddWithValue("@reason", reason);

                    command.Prepare();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Leave request details have been saved!");
                    this.EmployeeHomeTab.SelectedTab = this.HomeTab;
                    ReasontextBox.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot connect to database! Exiting");
                    throw;
                }
                conn.Close();
            }

        }

        private void SaveAttendanceButton_Click(object sender, EventArgs e)
        {
            if (OvertimeHours.Text == "" || RegularHours.Text == "")
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            DateTime _startDate = weeklyStartDate.Value;
            DateTime _endDate = weeklyEndDate.Value;
            double regularHours = double.Parse(RegularHours.Text);
            double overtime = double.Parse(OvertimeHours.Text);

            DatabaseConnectionWrapper databaseConnectionWrapper = new DatabaseConnectionWrapper();
            if (databaseConnectionWrapper != null)
            {
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"
                                INSERT INTO ATTENDANCE (EMPLOYEEID, STARTDATE, ENDDATE,
                                REGULARHOURS, OVERTIMEHOURS) values(@emp_id, @start, 
                                @end, @reg_hrs, @over_hrs);";

                    command.Parameters.AddWithValue("@emp_id", this.EmployeeID);
                    command.Parameters.AddWithValue("@start", _startDate);
                    command.Parameters.AddWithValue("@end", _endDate);
                    command.Parameters.AddWithValue("@reg_hrs", regularHours);
                    command.Parameters.AddWithValue("@over_hrs", overtime);

                    command.Prepare();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Attendance details have been saved!");
                    this.EmployeeHomeTab.SelectedTab = this.HomeTab;
                    foreach (TextBox a in new[] { RegularHours , OvertimeHours})
                    {
                        a.Text = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot connect to database! Exiting");
                    throw;
                }
                conn.Close();
            }

        }

        private void SaveDetailsButton_Click(object sender, EventArgs e)
        {
            TextBox[] textcontrols = { IDtextBox, FnameTextBox, LnameTextBox, AgeTextBox, DepartmentTextBox, PayGradeTextBox };

            int emp_id = int.Parse(IDtextBox.Text );
            string fname = FnameTextBox.Text ;
            string lname = LnameTextBox.Text ;
            string gender = GenderSelect.Text ;
            int age = int.Parse(AgeTextBox.Text);
            int dept_id = int.Parse(DepartmentTextBox.Text);
            int grade_id = int.Parse(PayGradeTextBox.Text);

            DatabaseConnectionWrapper databaseConnectionWrapper = new DatabaseConnectionWrapper();
            if (databaseConnectionWrapper != null)
            {
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand(); 
                    command.CommandText = @"
                                UPDATE EMPLOYEE SET 
                                    FNAME = @fname,
                                    LNAME = @lname, 
                                    AGE = @age, 
                                    GENDER = @gender,
                                    DEPARTMENTID = @deptid, 
                                    GRADEID = @grade
                                WHERE EMPLOYEEID = @emp_id;";

                    command.Parameters.AddWithValue("@emp_id", this.EmployeeID);
                    command.Parameters.AddWithValue("@fname", fname);
                    command.Parameters.AddWithValue("@lname", lname);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@gender", gender);

                    command.Parameters.AddWithValue("@deptid", dept_id);
                    command.Parameters.AddWithValue("@grade", grade_id);

                    command.Prepare();

                    command.ExecuteNonQuery();
                    MessageBox.Show("Your details have been updated!");
                    this.EmployeeHomeTab.SelectedTab = this.HomeTab;
                    foreach (TextBox a in textcontrols)
                    {
                        a.Text = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot connect to database! Exiting");
                    throw;
                }
                conn.Close();
            }

        }
        private void GetEmployeeDetails()
        {
            DatabaseConnectionWrapper databaseConnectionWrapper = new DatabaseConnectionWrapper();
            if (databaseConnectionWrapper != null)
            {
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"SELECT * FROM EMPLOYEE WHERE EMPLOYEEID=@emp_id;";
                    command.Parameters.AddWithValue("@emp_id", this.EmployeeID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fname = reader.GetString("FNAME");
                            string lname = reader.GetString("LNAME");
                            string gender = reader.GetString("GENDER");
                            int emp_id = reader.GetInt32("EMPLOYEEID");
                            int age = reader.GetInt32("AGE");
                            int dept_id = reader.GetInt32("DEPARTMENTID");
                            int grade_id = reader.GetInt32("GRADEID");

                            IDtextBox.Text = emp_id.ToString();
                            FnameTextBox.Text = fname;
                            LnameTextBox.Text = lname;
                            GenderSelect.Text = gender;
                            AgeTextBox.Text = age.ToString();
                            DepartmentTextBox.Text = dept_id.ToString();
                            PayGradeTextBox.Text = grade_id.ToString();

                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot connect to database! Exiting");
                    throw;
                }
                conn.Close();
            }
        }
    }
}
