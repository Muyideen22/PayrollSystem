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
            LoadDepartments();
            LoadPayGrades();
            GetEmployeeDetails();
            EmployeeHomeTab.SelectedTab = DetailsTab;
        }

        private void AddAttendancebutton_Click(object sender, EventArgs e)
        {
            EmployeeHomeTab.SelectedTab = attendanceTab;

        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            EmployeeHomeTab.SelectedTab = LeaveTab;

        }

        private void SaveLeavebutton_Click(object sender, EventArgs e)
        {
            string reason = ReasontextBox.Text;
            DateTime _startDate = startDate.Value;
            DateTime _endDate = endDate.Value;

            try
            {
                MySqlCommand command = new();
                command.CommandText = @"
                                INSERT INTO LEAVEREQUEST (EMPLOYEEID, STARTDATE, ENDDATE, REASON)
                                values(@emp_id, @start,@end, @reason);";

                command.Parameters.AddWithValue("@emp_id", EmployeeID);
                command.Parameters.AddWithValue("@start", _startDate);
                command.Parameters.AddWithValue("@end", _endDate);
                command.Parameters.AddWithValue("@reason", reason);

                RunNonQuery(command);
                MessageBox.Show("Leave request details have been saved!");
                EmployeeHomeTab.SelectedTab = HomeTab;
                ReasontextBox.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to database! Exiting");
                throw;
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

            try
            {
                MySqlCommand command = new();
                command.CommandText = @"
                                INSERT INTO ATTENDANCE (EMPLOYEEID, STARTDATE, ENDDATE,
                                REGULARHOURS, OVERTIMEHOURS) values(@emp_id, @start, 
                                @end, @reg_hrs, @over_hrs);";

                command.Parameters.AddWithValue("@emp_id", EmployeeID);
                command.Parameters.AddWithValue("@start", _startDate);
                command.Parameters.AddWithValue("@end", _endDate);
                command.Parameters.AddWithValue("@reg_hrs", regularHours);
                command.Parameters.AddWithValue("@over_hrs", overtime);

                RunNonQuery(command);
                MessageBox.Show("Attendance details have been saved!");
                EmployeeHomeTab.SelectedTab = HomeTab;
                foreach (TextBox a in new[] { RegularHours, OvertimeHours })
                {
                    a.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to database! Exiting");
                throw;
            }

        }

        private void SaveDetailsButton_Click(object sender, EventArgs e)
        {
            TextBox[] textcontrols = { IDtextBox, FnameTextBox, LnameTextBox, AgeTextBox};

            string fname = FnameTextBox.Text;
            string lname = LnameTextBox.Text;
            string gender = GenderSelect.Text;
            int age = int.Parse(AgeTextBox.Text);
            int dept_id = ((KeyValuePair<string, int>)DepartmentcomboBox.SelectedItem).Value;
            int grade_id = ((KeyValuePair<string, int>)PayGradeComboBox.SelectedItem).Value;

            try
            {
                MySqlCommand command = new();
                command.CommandText = @"
                                UPDATE EMPLOYEE SET 
                                    FNAME = @fname,
                                    LNAME = @lname, 
                                    AGE = @age, 
                                    GENDER = @gender,
                                    DEPARTMENTID = @deptid, 
                                    GRADEID = @grade
                                WHERE EMPLOYEEID = @emp_id;";

                command.Parameters.AddWithValue("@emp_id", EmployeeID);
                command.Parameters.AddWithValue("@fname", fname);
                command.Parameters.AddWithValue("@lname", lname);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@gender", gender);

                command.Parameters.AddWithValue("@deptid", dept_id);
                command.Parameters.AddWithValue("@grade", grade_id);

                RunNonQuery(command);

                MessageBox.Show("Your details have been updated!");
                EmployeeHomeTab.SelectedTab = HomeTab;
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

        }
        private void GetEmployeeDetails()
        {
            DatabaseConnectionWrapper databaseConnectionWrapper = new ();
            if (databaseConnectionWrapper != null)
            {
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"SELECT * FROM EMPLOYEE WHERE EMPLOYEEID=@emp_id;";
                    command.Parameters.AddWithValue("@emp_id", EmployeeID);

                    using MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        IDtextBox.Text = reader.GetInt32("EMPLOYEEID").ToString();
                        FnameTextBox.Text = reader.GetString("FNAME");
                        LnameTextBox.Text = reader.GetString("LNAME");
                        GenderSelect.Text = reader.GetString("GENDER");
                        AgeTextBox.Text = reader.GetInt32("AGE").ToString();
                        int dept = reader.GetInt32("DEPARTMENTID");
                        int grade = reader.GetInt32("GRADEID");
                        DepartmentcomboBox.SelectedValue = dept;

                        PayGradeComboBox.SelectedValue = grade;
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
        private void LoadPayGrades()
        {
            //this.PayGradeComboBox.Items.Clear();
            List<PayGrade> paygrades = GetPaygrades();
            this.PayGradeComboBox.DisplayMember = "Key";
            this.PayGradeComboBox.ValueMember = "Value";
            Dictionary<string, int> comboSource = new();

            foreach (PayGrade grade in paygrades)
            {
                comboSource.Add(grade.GradeName, grade.GradeID);

            }
            PayGradeComboBox.DataSource = new BindingSource(comboSource, null);

        }
        private void LoadDepartments()
        {
            List<Department> departments = GetDepartments();
            //this.DepartmentcomboBox.Items.Clear();
            this.DepartmentcomboBox.DisplayMember = "Key";
            this.DepartmentcomboBox.ValueMember = "Value";
            Dictionary<string, int> comboSource = new();

            foreach (Department department in departments)
            {
                comboSource.Add(department.DepartmentName, department.DepartmentID);
            }
            DepartmentcomboBox.DataSource = new BindingSource(comboSource, null);

        }
        private List<Department> GetDepartments()
        {
            List<Department> departmentList = new();

            if (databaseConnectionWrapper != null)
            {
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"SELECT * FROM DEPARTMENT;";

                    using MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string name = reader.GetString("DEPARTMENTNAME");
                        int dept_id = reader.GetInt32("DEPARTMENTID");

                        departmentList.Add(new Department(dept_id, name));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot connect to database! Exiting");
                    throw;
                }
                conn.Close();
            }
            return departmentList;
        }
        private List<PayGrade> GetPaygrades()
        {
            List<PayGrade> paygradesList = new();

            if (databaseConnectionWrapper != null)
            {
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"SELECT * FROM PAYGRADE;";

                    using MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string name = reader.GetString(1);
                        double hourly = reader.GetDouble(2);
                        double overtime = reader.GetDouble(3);
                        int grade_id = reader.GetInt32(0);
                        paygradesList.Add(new PayGrade(grade_id, name, hourly, overtime));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot connect to database! Exiting");
                    throw;
                }
                conn.Close();
            }
            return paygradesList;
        }
        private void RunNonQuery(MySqlCommand cmd)
        {
            MySqlConnection conn = databaseConnectionWrapper.Connection;
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            conn.Close();
        }
    }
}
