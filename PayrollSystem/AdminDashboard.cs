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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AddEmployeebutton_Click(object sender, EventArgs e)
        {
            homeTab.SelectedTab = AddEmployeeTab;
        }

        private void ViewEmployeesbutton_Click(object sender, EventArgs e)
        {
            homeTab.SelectedTab = ViewEmployeesTab;
            PopulateEmployeesListView();
        }

        private void PopulateEmployeesListView()
        {
            List<Employee> employees = GetEmployees();
            listViewEmployees.Items.Clear();
            listViewEmployees.Columns.Clear();
            foreach (string a in new[] { "ID", "First Name", "Last Name", "Gender", "Age",
                                    "Department", "Pay Grade"})
            {
                listViewEmployees.Columns.Add(a, 100);

            }
            foreach (Employee employee in employees)
            {
                listViewEmployees.Items.Add(
                    new ListViewItem(
                        new[] {
                            employee.EmployeeID.ToString(),
                            employee.FName,
                            employee.LName,
                            employee.Gender,
                            employee.Age.ToString(),
                            employee.Department.ToString(),
                            employee.Grade.ToString()
                        })
                    );
            }
        }

        private void AddPaygradeButton_Click(object sender, EventArgs e)
        {
            homeTab.SelectedTab = addPayGradeTab;
        }

        private void ViewPayGradesbutton_Click(object sender, EventArgs e)
        {
            homeTab.SelectedTab = viewPayGradeTab;
            List<PayGrade> paygrades = GetPaygrades();
            PayGradeslistView.Items.Clear();
            PayGradeslistView.Columns.Clear();
            foreach (String a in new[] { "ID", "Name", "Hourly Pay", "Overtime Pay" })
            {
                PayGradeslistView.Columns.Add(a, 100);
            }
            foreach (PayGrade grade in paygrades)
            {
                PayGradeslistView.Items.Add(
                    new ListViewItem(
                        new[] {
                            grade.GradeID.ToString(),
                            grade.GradeName,
                            grade.HourlyPay.ToString(),
                            grade.overTimePay.ToString(),
                }));
            }
        }

        private void PayrollButton_Click(object sender, EventArgs e)
        {
            homeTab.SelectedTab = payRollInfoTab;
        }

        private void SaveEmployeeButton_Click(object sender, EventArgs e)
        {

            foreach (TextBox a in new[]{
                EmployeeFnametextBox, EmployeeLnametextBox, EmployeeAgetextBox})
            {
                if (a.Text == "")
                {
                    MessageBox.Show("All fields are required!");
                    return;
                }
            }

            string fname = EmployeeFnametextBox.Text;
            string lname = EmployeeLnametextBox.Text;
            string gender = EmployeeGenderComboBox.Text;
            int age = int.Parse(EmployeeAgetextBox.Text);
            int department = ((KeyValuePair<string, int>)DepartmentsComboBox.SelectedItem).Value;
            int payGrade = ((KeyValuePair<string, int>)PayGradecomboBox.SelectedItem).Value;
            try
            {
                MySqlCommand command = new();
                command.CommandText = @"INSERT INTO EMPLOYEE (FNAME, LNAME, AGE, GENDER, DEPARTMENTID, GRADEID, USERNAME, USERPASSWORD) VALUES (@fname, @lname, @age, @gender, @deptid, @grade, @username, PASSWORD(@userpass));";
                command.Parameters.AddWithValue("@fname", fname);
                command.Parameters.AddWithValue("@lname", lname);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@gender", gender);

                command.Parameters.AddWithValue("@deptid", department);
                command.Parameters.AddWithValue("@grade", payGrade);

                string username = $"{lname}{age}";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@userpass", "password");

                RunNonQuery(command);

                MessageBox.Show("New employee has been added!");
                homeTab.SelectedTab = Home_Tab;
                foreach (TextBox a in new[]{
                        EmployeeFnametextBox, EmployeeLnametextBox, EmployeeAgetextBox})
                {
                    a.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Exiting");
                Console.WriteLine(ex.Message);
                Application.Exit();
                throw;
            }

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

        private void SaveDepartmentbutton_Click(object sender, EventArgs e)
        {
            string dept_name = DeptNametextBox.Text;
            if (dept_name == "")
            {
                MessageBox.Show("Department Name is needed!");
                return;
            }
            try
            {
                MySqlCommand cmd = new();
                cmd.CommandText = @"INSERT INTO DEPARTMENT (DEPARTMENTNAME) VALUES (@deptname);";
                cmd.Parameters.AddWithValue("@deptname", dept_name);
                RunNonQuery(cmd);

                MessageBox.Show("New department has been added!");
                DeptNametextBox.Text = "";
                homeTab.SelectedTab = Home_Tab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        private List<Employee> GetEmployees()
        {
            List<Employee> employeesList = new();

            if (databaseConnectionWrapper != null)
            {
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"SELECT * FROM EMPLOYEE;";

                    using MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string fname = reader.GetString("FNAME");
                        string lname = reader.GetString("LNAME");
                        string gender = reader.GetString("GENDER");
                        int emp_id = reader.GetInt32("EMPLOYEEID");
                        int age = reader.GetInt32("AGE");
                        int dept_id = reader.GetInt32("DEPARTMENTID");
                        int grade_id = reader.GetInt32("GRADEID");


                        employeesList.Add(new Employee(emp_id, fname, lname, gender, age, dept_id, grade_id));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot connect to database! Exiting");
                    throw;
                }
                conn.Close();
            }
            return employeesList;

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
        private void SaveGradebutton_Click(object sender, EventArgs e)
        {
            if (gradeNameTextbox.Text == "" || hourlyPayTextBox.Text == "" || OvertimetextBox.Text == "")
            {
                MessageBox.Show("Please fill all details!");
                return;
            }
            string grade_name = gradeNameTextbox.Text;
            double hourly = double.Parse(hourlyPayTextBox.Text);
            double overtime = double.Parse(OvertimetextBox.Text);

            try
            {
                MySqlCommand command = new();
                command.CommandText = @"INSERT INTO PAYGRADE (GRADENAME, HOURLYPAY, OVERTIMEPAY) VALUES (@name, @hourly, @overtime);";
                command.Parameters.AddWithValue("@name", grade_name);
                command.Parameters.AddWithValue("@hourly", hourly);
                command.Parameters.AddWithValue("@overtime", overtime);

                RunNonQuery(command);
                MessageBox.Show("New pay grade has been added!");
                homeTab.SelectedTab = Home_Tab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void ViewDepartmentButton_Click(object sender, EventArgs e)
        {
            homeTab.SelectedTab = ViewDepartmentTab;

            List<Department> departments = GetDepartments();
            DepartmentlistView.Items.Clear();
            DepartmentlistView.Columns.Clear();
            DepartmentlistView.Columns.Add("ID", 150);
            DepartmentlistView.Columns.Add("Name", 150);
            foreach (Department dept in departments)
            {
                DepartmentlistView.Items.Add(
                    new ListViewItem(
                        new[] {
                            dept.DepartmentID.ToString(),
                            dept.DepartmentName
                        })
                    );
            }
        }

        private void AddDepartmentbutton_Click(object sender, EventArgs e)
        {
            homeTab.SelectedTab = AddDepartmentTab;
        }

        private void GeneratePayroll()
        {

        }

        private void LoadDepartments(object sender, EventArgs e)
        {
            List<Department> departments = GetDepartments();
            //this.DepartmentsComboBox.Items.Clear();
            this.DepartmentsComboBox.DisplayMember = "Key";
            this.DepartmentsComboBox.ValueMember = "Value";
            Dictionary<string, int> comboSource = new();

            foreach (Department department in departments)
            {
                comboSource.Add(department.DepartmentName, department.DepartmentID);
            }
            DepartmentsComboBox.DataSource = new BindingSource(comboSource, null);

        }

        private void LoadPayGrades(object sender, EventArgs e)
        {
            //this.PayGradecomboBox.Items.Clear();
            List<PayGrade> paygrades = GetPaygrades();
            this.PayGradecomboBox.DisplayMember = "Key";
            this.PayGradecomboBox.ValueMember = "Value";
            Dictionary<string, int> comboSource = new();

            foreach (PayGrade grade in paygrades)
            {
                comboSource.Add(grade.GradeName, grade.GradeID);

            }
            PayGradecomboBox.DataSource = new BindingSource(comboSource, null);

        }
    }
}
