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
            //TODO
            this.homeTab.SelectedTab = this.ViewEmployeesTab;

            List<Employee> employees = getEmployees();
            listViewEmployees.Items.Clear();
            
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
                        }
                        )
                    );
            }
            
        }

        private void addPaygradeButton_Click(object sender, EventArgs e)
        {
            this.homeTab.SelectedTab = this.addPayGradeTab;
        }

        private void ViewPayGradesbutton_Click(object sender, EventArgs e)
        {
            this.homeTab.SelectedTab = this.viewPayGradeTab;
            List<PayGrade> paygrades = getPaygrades();
            //paygrades.Items.Clear();
            foreach (PayGrade grade in paygrades)
            {
                DepartmentlistView.Items.Add(
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
            this.homeTab.SelectedTab = this.payRollInfoTab;
        }

        private void SaveEmployeeButton_Click(object sender, EventArgs e)
        {
            TextBox[] textcontrols = { EmployeeFnametextBox, EmployeeLnametextBox, EmployeeAgetextBox, EmployeeDepartmentTextbox, EmployeePaygradeTextBox };
            foreach (TextBox a in textcontrols)
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
            string department = EmployeeDepartmentTextbox.Text;
            string payGrade = EmployeePaygradeTextBox.Text;

            DatabaseConnectionWrapper databaseConnectionWrapper = new DatabaseConnectionWrapper();
            if (databaseConnectionWrapper != null)
            {


                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"INSERT INTO EMPLOYEE (FNAME, LNAME, AGE, GENDER, DEPARTMENTID, GRADEID) VALUES (@fname, @lname, @age, @gender, @deptid, @grade);";
                    command.Parameters.AddWithValue("@fname", fname);
                    command.Parameters.AddWithValue("@lname", lname);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@gender", gender);

                    command.Parameters.AddWithValue("@deptid", 1);
                    command.Parameters.AddWithValue("@grade", 1);

                    command.Prepare();

                    command.ExecuteNonQuery();
                    MessageBox.Show("New employee has been added!");
                    this.homeTab.SelectedTab = this.Home_Tab;
                    foreach (TextBox a in textcontrols)
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
                conn.Close();
            }
        }

        private void SaveDepartmentbutton_Click(object sender, EventArgs e)
        {
            string dept_name = DeptNametextBox.Text;
            if (dept_name == "")
            {
                MessageBox.Show("Department Name is needed!");
                return;
            }

            DatabaseConnectionWrapper databaseConnectionWrapper = new DatabaseConnectionWrapper();
            if (databaseConnectionWrapper != null)
            {


                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"INSERT INTO DEPARTMENT (DEPARTMENTNAME) VALUES (@deptname);";


                    command.Parameters.AddWithValue("@deptname", dept_name);

                    command.Prepare();

                    command.ExecuteNonQuery();
                    MessageBox.Show("New department has been added!");
                    DeptNametextBox.Text = "";
                    this.homeTab.SelectedTab = this.Home_Tab;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
                conn.Close();
            }
        }
        private List<Employee> getEmployees() 
        {
            List<Employee> employeesList = new List<Employee>();
            DatabaseConnectionWrapper databaseConnectionWrapper = new DatabaseConnectionWrapper();
            if (databaseConnectionWrapper != null)
            {
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"SELECT * FROM EMPLOYEE;";

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


                            employeesList.Add(new Employee(emp_id, fname, lname, gender, age, dept_id, grade_id));
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
            return employeesList;

        }
        private List<Department> getDepartments()
        {
            List<Department> departmentList = new List<Department>();
            DatabaseConnectionWrapper databaseConnectionWrapper = new DatabaseConnectionWrapper();
            if (databaseConnectionWrapper != null)
            {
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"SELECT * FROM DEPARTMENT;";

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString("DEPARTMENTNAME");
                            int dept_id = reader.GetInt32("DEPARTMENTID");

                            departmentList.Add(new Department(dept_id, name));
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
            return departmentList;
        }
        private List<PayGrade> getPaygrades()
        {
            List<PayGrade> paygradesList = new List<PayGrade>();
            DatabaseConnectionWrapper databaseConnectionWrapper = new DatabaseConnectionWrapper();
            if (databaseConnectionWrapper != null)
            {
                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"SELECT * FROM PAYGRADE;";

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(1);
                            double hourly = reader.GetDouble(2);
                            double overtime = reader.GetDouble(3);
                            int grade_id = reader.GetInt32(0);
                            paygradesList.Add(new PayGrade(grade_id, name, hourly, overtime));


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

            DatabaseConnectionWrapper databaseConnectionWrapper = new DatabaseConnectionWrapper();
            if (databaseConnectionWrapper != null)
            {


                MySqlConnection conn = databaseConnectionWrapper.Connection;
                try
                {
                    conn.Open();
                    using var command = conn.CreateCommand();
                    command.CommandText = @"INSERT INTO PAYGRADE (GRADENAME, HOURLYPAY, OVERTIMEPAY) VALUES (@name, @hourly, @overtime);";


                    command.Parameters.AddWithValue("@name", grade_name);
                    command.Parameters.AddWithValue("@hourly", hourly);
                    command.Parameters.AddWithValue("@overtime", overtime);


                    command.Prepare();

                    command.ExecuteNonQuery();
                    MessageBox.Show("New pay grade has been added!");
                    
                    homeTab.SelectedTab = Home_Tab;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
                conn.Close();
            }
        }

        private void ViewDepartmentButton_Click(object sender, EventArgs e)
        {
            List<Department> departments = getDepartments();
            DepartmentlistView.Items.Clear();
            foreach (Department dept in departments)
            {
                DepartmentlistView.Items.Add(
                    new ListViewItem(
                        new[] {
                            dept.DepartmentID.ToString(),
                            dept.DepartmentName
                        }
                        )
                    );
            }
        }

        private void AddDepartmentbutton_Click(object sender, EventArgs e)
        {
            this.homeTab.SelectedTab = this.AddDepartmentTab;
        }
    }
}
