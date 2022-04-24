namespace PayrollSystem
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private DatabaseConnectionWrapper databaseConnectionWrapper = new DatabaseConnectionWrapper();
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeTab = new System.Windows.Forms.TabControl();
            this.Home_Tab = new System.Windows.Forms.TabPage();
            this.ViewDepartmentButton = new System.Windows.Forms.Button();
            this.AddDepartmentbutton = new System.Windows.Forms.Button();
            this.ViewEmployeesbutton = new System.Windows.Forms.Button();
            this.PayrollButton = new System.Windows.Forms.Button();
            this.ViewPayGradesbutton = new System.Windows.Forms.Button();
            this.addPaygradeButton = new System.Windows.Forms.Button();
            this.addEmployeebutton = new System.Windows.Forms.Button();
            this.AddEmployeeTab = new System.Windows.Forms.TabPage();
            this.PayGradecomboBox = new System.Windows.Forms.ComboBox();
            this.DepartmentsComboBox = new System.Windows.Forms.ComboBox();
            this.SaveEmployeeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EmployeeGenderComboBox = new System.Windows.Forms.ComboBox();
            this.EmployeeAgetextBox = new System.Windows.Forms.TextBox();
            this.EmployeeLnametextBox = new System.Windows.Forms.TextBox();
            this.EmployeeFnametextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewEmployeesTab = new System.Windows.Forms.TabPage();
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.Gender = new System.Windows.Forms.ColumnHeader();
            this.Age = new System.Windows.Forms.ColumnHeader();
            this.Department = new System.Windows.Forms.ColumnHeader();
            this.PayGrade = new System.Windows.Forms.ColumnHeader();
            this.AddDepartmentTab = new System.Windows.Forms.TabPage();
            this.DeptNametextBox = new System.Windows.Forms.TextBox();
            this.SaveDepartmentbutton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ViewDepartmentTab = new System.Windows.Forms.TabPage();
            this.DepartmentlistView = new System.Windows.Forms.ListView();
            this.DepartmentID = new System.Windows.Forms.ColumnHeader();
            this.DepartmentName = new System.Windows.Forms.ColumnHeader();
            this.viewPayGradeTab = new System.Windows.Forms.TabPage();
            this.PayGradeslistView = new System.Windows.Forms.ListView();
            this.addPayGradeTab = new System.Windows.Forms.TabPage();
            this.SaveGradebutton = new System.Windows.Forms.Button();
            this.OvertimetextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayTextBox = new System.Windows.Forms.TextBox();
            this.gradeNameTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.payRollInfoTab = new System.Windows.Forms.TabPage();
            this.homeTab.SuspendLayout();
            this.Home_Tab.SuspendLayout();
            this.AddEmployeeTab.SuspendLayout();
            this.ViewEmployeesTab.SuspendLayout();
            this.AddDepartmentTab.SuspendLayout();
            this.ViewDepartmentTab.SuspendLayout();
            this.viewPayGradeTab.SuspendLayout();
            this.addPayGradeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.Home_Tab);
            this.homeTab.Controls.Add(this.AddEmployeeTab);
            this.homeTab.Controls.Add(this.ViewEmployeesTab);
            this.homeTab.Controls.Add(this.AddDepartmentTab);
            this.homeTab.Controls.Add(this.ViewDepartmentTab);
            this.homeTab.Controls.Add(this.viewPayGradeTab);
            this.homeTab.Controls.Add(this.addPayGradeTab);
            this.homeTab.Controls.Add(this.payRollInfoTab);
            this.homeTab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeTab.Location = new System.Drawing.Point(12, 12);
            this.homeTab.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.homeTab.Name = "homeTab";
            this.homeTab.SelectedIndex = 0;
            this.homeTab.Size = new System.Drawing.Size(1926, 803);
            this.homeTab.TabIndex = 0;
            // 
            // Home_Tab
            // 
            this.Home_Tab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Home_Tab.Controls.Add(this.ViewDepartmentButton);
            this.Home_Tab.Controls.Add(this.AddDepartmentbutton);
            this.Home_Tab.Controls.Add(this.ViewEmployeesbutton);
            this.Home_Tab.Controls.Add(this.PayrollButton);
            this.Home_Tab.Controls.Add(this.ViewPayGradesbutton);
            this.Home_Tab.Controls.Add(this.addPaygradeButton);
            this.Home_Tab.Controls.Add(this.addEmployeebutton);
            this.Home_Tab.Location = new System.Drawing.Point(8, 51);
            this.Home_Tab.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Home_Tab.Name = "Home_Tab";
            this.Home_Tab.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Home_Tab.Size = new System.Drawing.Size(1910, 744);
            this.Home_Tab.TabIndex = 0;
            this.Home_Tab.Text = "Home";
            // 
            // ViewDepartmentButton
            // 
            this.ViewDepartmentButton.Location = new System.Drawing.Point(846, 450);
            this.ViewDepartmentButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ViewDepartmentButton.Name = "ViewDepartmentButton";
            this.ViewDepartmentButton.Size = new System.Drawing.Size(357, 58);
            this.ViewDepartmentButton.TabIndex = 6;
            this.ViewDepartmentButton.Text = "View Departments";
            this.ViewDepartmentButton.UseVisualStyleBackColor = true;
            this.ViewDepartmentButton.Click += new System.EventHandler(this.ViewDepartmentButton_Click);
            // 
            // AddDepartmentbutton
            // 
            this.AddDepartmentbutton.Location = new System.Drawing.Point(252, 450);
            this.AddDepartmentbutton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddDepartmentbutton.Name = "AddDepartmentbutton";
            this.AddDepartmentbutton.Size = new System.Drawing.Size(347, 58);
            this.AddDepartmentbutton.TabIndex = 5;
            this.AddDepartmentbutton.Text = "Add Department";
            this.AddDepartmentbutton.UseVisualStyleBackColor = true;
            this.AddDepartmentbutton.Click += new System.EventHandler(this.AddDepartmentbutton_Click);
            // 
            // ViewEmployeesbutton
            // 
            this.ViewEmployeesbutton.Location = new System.Drawing.Point(846, 164);
            this.ViewEmployeesbutton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ViewEmployeesbutton.Name = "ViewEmployeesbutton";
            this.ViewEmployeesbutton.Size = new System.Drawing.Size(357, 58);
            this.ViewEmployeesbutton.TabIndex = 4;
            this.ViewEmployeesbutton.Text = "View Employees";
            this.ViewEmployeesbutton.UseVisualStyleBackColor = true;
            this.ViewEmployeesbutton.Click += new System.EventHandler(this.ViewEmployeesbutton_Click);
            // 
            // PayrollButton
            // 
            this.PayrollButton.Location = new System.Drawing.Point(252, 569);
            this.PayrollButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PayrollButton.Name = "PayrollButton";
            this.PayrollButton.Size = new System.Drawing.Size(347, 58);
            this.PayrollButton.TabIndex = 3;
            this.PayrollButton.Text = "Generate Payroll";
            this.PayrollButton.UseVisualStyleBackColor = true;
            this.PayrollButton.Click += new System.EventHandler(this.PayrollButton_Click);
            // 
            // ViewPayGradesbutton
            // 
            this.ViewPayGradesbutton.Location = new System.Drawing.Point(846, 312);
            this.ViewPayGradesbutton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ViewPayGradesbutton.Name = "ViewPayGradesbutton";
            this.ViewPayGradesbutton.Size = new System.Drawing.Size(357, 58);
            this.ViewPayGradesbutton.TabIndex = 2;
            this.ViewPayGradesbutton.Text = "View PayGrades";
            this.ViewPayGradesbutton.UseVisualStyleBackColor = true;
            this.ViewPayGradesbutton.Click += new System.EventHandler(this.ViewPayGradesbutton_Click);
            // 
            // addPaygradeButton
            // 
            this.addPaygradeButton.Location = new System.Drawing.Point(252, 312);
            this.addPaygradeButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addPaygradeButton.Name = "addPaygradeButton";
            this.addPaygradeButton.Size = new System.Drawing.Size(347, 58);
            this.addPaygradeButton.TabIndex = 1;
            this.addPaygradeButton.Text = "Add paygrade";
            this.addPaygradeButton.UseVisualStyleBackColor = true;
            this.addPaygradeButton.Click += new System.EventHandler(this.AddPaygradeButton_Click);
            // 
            // addEmployeebutton
            // 
            this.addEmployeebutton.Location = new System.Drawing.Point(252, 164);
            this.addEmployeebutton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addEmployeebutton.Name = "addEmployeebutton";
            this.addEmployeebutton.Size = new System.Drawing.Size(347, 58);
            this.addEmployeebutton.TabIndex = 0;
            this.addEmployeebutton.Text = "Add Employee";
            this.addEmployeebutton.UseVisualStyleBackColor = true;
            this.addEmployeebutton.Click += new System.EventHandler(this.AddEmployeebutton_Click);
            // 
            // AddEmployeeTab
            // 
            this.AddEmployeeTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddEmployeeTab.Controls.Add(this.PayGradecomboBox);
            this.AddEmployeeTab.Controls.Add(this.DepartmentsComboBox);
            this.AddEmployeeTab.Controls.Add(this.SaveEmployeeButton);
            this.AddEmployeeTab.Controls.Add(this.label7);
            this.AddEmployeeTab.Controls.Add(this.EmployeeGenderComboBox);
            this.AddEmployeeTab.Controls.Add(this.EmployeeAgetextBox);
            this.AddEmployeeTab.Controls.Add(this.EmployeeLnametextBox);
            this.AddEmployeeTab.Controls.Add(this.EmployeeFnametextBox);
            this.AddEmployeeTab.Controls.Add(this.label6);
            this.AddEmployeeTab.Controls.Add(this.label5);
            this.AddEmployeeTab.Controls.Add(this.label4);
            this.AddEmployeeTab.Controls.Add(this.label3);
            this.AddEmployeeTab.Controls.Add(this.label2);
            this.AddEmployeeTab.Location = new System.Drawing.Point(8, 59);
            this.AddEmployeeTab.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddEmployeeTab.Name = "AddEmployeeTab";
            this.AddEmployeeTab.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddEmployeeTab.Size = new System.Drawing.Size(1507, 459);
            this.AddEmployeeTab.TabIndex = 1;
            this.AddEmployeeTab.Text = "Add Employee";
            // 
            // PayGradecomboBox
            // 
            this.PayGradecomboBox.FormattingEnabled = true;
            this.PayGradecomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PayGradecomboBox.Location = new System.Drawing.Point(612, 564);
            this.PayGradecomboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PayGradecomboBox.Name = "PayGradecomboBox";
            this.PayGradecomboBox.Size = new System.Drawing.Size(449, 45);
            this.PayGradecomboBox.TabIndex = 16;
            this.PayGradecomboBox.Click += new System.EventHandler(this.LoadPayGrades);
            // 
            // DepartmentsComboBox
            // 
            this.DepartmentsComboBox.FormattingEnabled = true;
            this.DepartmentsComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DepartmentsComboBox.Location = new System.Drawing.Point(612, 458);
            this.DepartmentsComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DepartmentsComboBox.Name = "DepartmentsComboBox";
            this.DepartmentsComboBox.Size = new System.Drawing.Size(449, 45);
            this.DepartmentsComboBox.TabIndex = 15;
            this.DepartmentsComboBox.Click += new System.EventHandler(this.LoadDepartments);
            // 
            // SaveEmployeeButton
            // 
            this.SaveEmployeeButton.Location = new System.Drawing.Point(535, 672);
            this.SaveEmployeeButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SaveEmployeeButton.Name = "SaveEmployeeButton";
            this.SaveEmployeeButton.Size = new System.Drawing.Size(314, 66);
            this.SaveEmployeeButton.TabIndex = 14;
            this.SaveEmployeeButton.Text = "Save";
            this.SaveEmployeeButton.UseVisualStyleBackColor = true;
            this.SaveEmployeeButton.Click += new System.EventHandler(this.SaveEmployeeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 577);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pay Grade";
            // 
            // EmployeeGenderComboBox
            // 
            this.EmployeeGenderComboBox.FormattingEnabled = true;
            this.EmployeeGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmployeeGenderComboBox.Location = new System.Drawing.Point(612, 265);
            this.EmployeeGenderComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EmployeeGenderComboBox.Name = "EmployeeGenderComboBox";
            this.EmployeeGenderComboBox.Size = new System.Drawing.Size(307, 45);
            this.EmployeeGenderComboBox.TabIndex = 12;
            // 
            // EmployeeAgetextBox
            // 
            this.EmployeeAgetextBox.Location = new System.Drawing.Point(612, 341);
            this.EmployeeAgetextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EmployeeAgetextBox.Name = "EmployeeAgetextBox";
            this.EmployeeAgetextBox.Size = new System.Drawing.Size(256, 43);
            this.EmployeeAgetextBox.TabIndex = 9;
            // 
            // EmployeeLnametextBox
            // 
            this.EmployeeLnametextBox.Location = new System.Drawing.Point(612, 191);
            this.EmployeeLnametextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EmployeeLnametextBox.Name = "EmployeeLnametextBox";
            this.EmployeeLnametextBox.Size = new System.Drawing.Size(256, 43);
            this.EmployeeLnametextBox.TabIndex = 8;
            // 
            // EmployeeFnametextBox
            // 
            this.EmployeeFnametextBox.Location = new System.Drawing.Point(612, 103);
            this.EmployeeFnametextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EmployeeFnametextBox.Name = "EmployeeFnametextBox";
            this.EmployeeFnametextBox.Size = new System.Drawing.Size(256, 43);
            this.EmployeeFnametextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 458);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 347);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // ViewEmployeesTab
            // 
            this.ViewEmployeesTab.Controls.Add(this.listViewEmployees);
            this.ViewEmployeesTab.Location = new System.Drawing.Point(8, 59);
            this.ViewEmployeesTab.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ViewEmployeesTab.Name = "ViewEmployeesTab";
            this.ViewEmployeesTab.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ViewEmployeesTab.Size = new System.Drawing.Size(1507, 459);
            this.ViewEmployeesTab.TabIndex = 2;
            this.ViewEmployeesTab.Text = "View Employees";
            this.ViewEmployeesTab.UseVisualStyleBackColor = true;
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.Age,
            this.Department,
            this.PayGrade});
            this.listViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEmployees.FullRowSelect = true;
            this.listViewEmployees.GridLines = true;
            this.listViewEmployees.Location = new System.Drawing.Point(5, 5);
            this.listViewEmployees.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(1497, 449);
            this.listViewEmployees.TabIndex = 1;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            // 
            // AddDepartmentTab
            // 
            this.AddDepartmentTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddDepartmentTab.Controls.Add(this.DeptNametextBox);
            this.AddDepartmentTab.Controls.Add(this.SaveDepartmentbutton);
            this.AddDepartmentTab.Controls.Add(this.label10);
            this.AddDepartmentTab.Location = new System.Drawing.Point(8, 59);
            this.AddDepartmentTab.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddDepartmentTab.Name = "AddDepartmentTab";
            this.AddDepartmentTab.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddDepartmentTab.Size = new System.Drawing.Size(1507, 459);
            this.AddDepartmentTab.TabIndex = 3;
            this.AddDepartmentTab.Text = "Add Department";
            // 
            // DeptNametextBox
            // 
            this.DeptNametextBox.Location = new System.Drawing.Point(514, 217);
            this.DeptNametextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DeptNametextBox.Name = "DeptNametextBox";
            this.DeptNametextBox.Size = new System.Drawing.Size(256, 43);
            this.DeptNametextBox.TabIndex = 8;
            // 
            // SaveDepartmentbutton
            // 
            this.SaveDepartmentbutton.Location = new System.Drawing.Point(550, 394);
            this.SaveDepartmentbutton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SaveDepartmentbutton.Name = "SaveDepartmentbutton";
            this.SaveDepartmentbutton.Size = new System.Drawing.Size(375, 58);
            this.SaveDepartmentbutton.TabIndex = 6;
            this.SaveDepartmentbutton.Text = "Save Department";
            this.SaveDepartmentbutton.UseVisualStyleBackColor = true;
            this.SaveDepartmentbutton.Click += new System.EventHandler(this.SaveDepartmentbutton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 233);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 37);
            this.label10.TabIndex = 4;
            this.label10.Text = "Department Name";
            // 
            // ViewDepartmentTab
            // 
            this.ViewDepartmentTab.Controls.Add(this.DepartmentlistView);
            this.ViewDepartmentTab.Location = new System.Drawing.Point(8, 59);
            this.ViewDepartmentTab.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ViewDepartmentTab.Name = "ViewDepartmentTab";
            this.ViewDepartmentTab.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ViewDepartmentTab.Size = new System.Drawing.Size(1507, 459);
            this.ViewDepartmentTab.TabIndex = 4;
            this.ViewDepartmentTab.Text = "View Departments";
            this.ViewDepartmentTab.UseVisualStyleBackColor = true;
            // 
            // DepartmentlistView
            // 
            this.DepartmentlistView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DepartmentlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DepartmentID,
            this.DepartmentName});
            this.DepartmentlistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentlistView.GridLines = true;
            this.DepartmentlistView.Location = new System.Drawing.Point(5, 5);
            this.DepartmentlistView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DepartmentlistView.Name = "DepartmentlistView";
            this.DepartmentlistView.Size = new System.Drawing.Size(1497, 449);
            this.DepartmentlistView.TabIndex = 2;
            this.DepartmentlistView.UseCompatibleStateImageBehavior = false;
            this.DepartmentlistView.View = System.Windows.Forms.View.Details;
            // 
            // viewPayGradeTab
            // 
            this.viewPayGradeTab.Controls.Add(this.PayGradeslistView);
            this.viewPayGradeTab.Location = new System.Drawing.Point(8, 59);
            this.viewPayGradeTab.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.viewPayGradeTab.Name = "viewPayGradeTab";
            this.viewPayGradeTab.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.viewPayGradeTab.Size = new System.Drawing.Size(1507, 459);
            this.viewPayGradeTab.TabIndex = 5;
            this.viewPayGradeTab.Text = "View Pay Grades";
            this.viewPayGradeTab.UseVisualStyleBackColor = true;
            // 
            // PayGradeslistView
            // 
            this.PayGradeslistView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PayGradeslistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayGradeslistView.GridLines = true;
            this.PayGradeslistView.Location = new System.Drawing.Point(5, 5);
            this.PayGradeslistView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PayGradeslistView.Name = "PayGradeslistView";
            this.PayGradeslistView.Size = new System.Drawing.Size(1497, 449);
            this.PayGradeslistView.TabIndex = 0;
            this.PayGradeslistView.UseCompatibleStateImageBehavior = false;
            this.PayGradeslistView.View = System.Windows.Forms.View.Details;
            // 
            // addPayGradeTab
            // 
            this.addPayGradeTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addPayGradeTab.Controls.Add(this.SaveGradebutton);
            this.addPayGradeTab.Controls.Add(this.OvertimetextBox);
            this.addPayGradeTab.Controls.Add(this.hourlyPayTextBox);
            this.addPayGradeTab.Controls.Add(this.gradeNameTextbox);
            this.addPayGradeTab.Controls.Add(this.label11);
            this.addPayGradeTab.Controls.Add(this.label12);
            this.addPayGradeTab.Controls.Add(this.label13);
            this.addPayGradeTab.Location = new System.Drawing.Point(8, 59);
            this.addPayGradeTab.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addPayGradeTab.Name = "addPayGradeTab";
            this.addPayGradeTab.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addPayGradeTab.Size = new System.Drawing.Size(1507, 459);
            this.addPayGradeTab.TabIndex = 6;
            this.addPayGradeTab.Text = "Add Pay Grades";
            // 
            // SaveGradebutton
            // 
            this.SaveGradebutton.Location = new System.Drawing.Point(499, 492);
            this.SaveGradebutton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SaveGradebutton.Name = "SaveGradebutton";
            this.SaveGradebutton.Size = new System.Drawing.Size(314, 66);
            this.SaveGradebutton.TabIndex = 22;
            this.SaveGradebutton.Text = "Save";
            this.SaveGradebutton.UseVisualStyleBackColor = true;
            this.SaveGradebutton.Click += new System.EventHandler(this.SaveGradebutton_Click);
            // 
            // OvertimetextBox
            // 
            this.OvertimetextBox.Location = new System.Drawing.Point(689, 357);
            this.OvertimetextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.OvertimetextBox.Name = "OvertimetextBox";
            this.OvertimetextBox.Size = new System.Drawing.Size(256, 43);
            this.OvertimetextBox.TabIndex = 21;
            // 
            // hourlyPayTextBox
            // 
            this.hourlyPayTextBox.Location = new System.Drawing.Point(689, 275);
            this.hourlyPayTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.hourlyPayTextBox.Name = "hourlyPayTextBox";
            this.hourlyPayTextBox.Size = new System.Drawing.Size(256, 43);
            this.hourlyPayTextBox.TabIndex = 20;
            // 
            // gradeNameTextbox
            // 
            this.gradeNameTextbox.Location = new System.Drawing.Point(689, 191);
            this.gradeNameTextbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gradeNameTextbox.Name = "gradeNameTextbox";
            this.gradeNameTextbox.Size = new System.Drawing.Size(256, 43);
            this.gradeNameTextbox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 357);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 37);
            this.label11.TabIndex = 16;
            this.label11.Text = "Overtime pay";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(329, 281);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 37);
            this.label12.TabIndex = 15;
            this.label12.Text = "Hourly Pay";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(329, 191);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 37);
            this.label13.TabIndex = 14;
            this.label13.Text = "Grade Name";
            // 
            // payRollInfoTab
            // 
            this.payRollInfoTab.Location = new System.Drawing.Point(8, 59);
            this.payRollInfoTab.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.payRollInfoTab.Name = "payRollInfoTab";
            this.payRollInfoTab.Size = new System.Drawing.Size(1507, 459);
            this.payRollInfoTab.TabIndex = 7;
            this.payRollInfoTab.Text = "Payroll Info";
            this.payRollInfoTab.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2011, 854);
            this.Controls.Add(this.homeTab);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.homeTab.ResumeLayout(false);
            this.Home_Tab.ResumeLayout(false);
            this.AddEmployeeTab.ResumeLayout(false);
            this.AddEmployeeTab.PerformLayout();
            this.ViewEmployeesTab.ResumeLayout(false);
            this.AddDepartmentTab.ResumeLayout(false);
            this.AddDepartmentTab.PerformLayout();
            this.ViewDepartmentTab.ResumeLayout(false);
            this.viewPayGradeTab.ResumeLayout(false);
            this.addPayGradeTab.ResumeLayout(false);
            this.addPayGradeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl homeTab;
        private TabPage Home_Tab;
        private Button ViewEmployeesbutton;
        private Button PayrollButton;
        private Button ViewPayGradesbutton;
        private Button addPaygradeButton;
        private Button addEmployeebutton;
        private TabPage AddEmployeeTab;
        private TabPage ViewEmployeesTab;
        private TextBox EmployeeAgetextBox;
        private TextBox EmployeeLnametextBox;
        private TextBox EmployeeFnametextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox EmployeeGenderComboBox;
        private Button SaveEmployeeButton;
        private Label label7;
        private ListView listViewEmployees;
        private ColumnHeader ID;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Gender;
        private ColumnHeader Age;
        private ColumnHeader Department;
        private ColumnHeader PayGrade;
        private TabPage AddDepartmentTab;
        private Label label10;
        private TextBox DeptNametextBox;
        private Button SaveDepartmentbutton;
        private TabPage ViewDepartmentTab;
        private ListView DepartmentlistView;
        private ColumnHeader DepartmentID;
        private ColumnHeader DepartmentName;
        private TabPage viewPayGradeTab;
        private TabPage addPayGradeTab;
        private TabPage payRollInfoTab;
        private TextBox OvertimetextBox;
        private TextBox hourlyPayTextBox;
        private TextBox gradeNameTextbox;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button SaveGradebutton;
        private Button ViewDepartmentButton;
        private Button AddDepartmentbutton;
        private ListView PayGradeslistView;
        private ComboBox PayGradecomboBox;
        private ComboBox DepartmentsComboBox;
    }
}