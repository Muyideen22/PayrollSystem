namespace PayrollSystem
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeTab = new System.Windows.Forms.TabControl();
            this.Home_Tab = new System.Windows.Forms.TabPage();
            this.ViewEmployeesbutton = new System.Windows.Forms.Button();
            this.PayrollButton = new System.Windows.Forms.Button();
            this.ViewPayGradesbutton = new System.Windows.Forms.Button();
            this.addPaygradeButton = new System.Windows.Forms.Button();
            this.addEmployeebutton = new System.Windows.Forms.Button();
            this.AddEmployeeTab = new System.Windows.Forms.TabPage();
            this.SaveEmployeeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EmployeeGenderComboBox = new System.Windows.Forms.ComboBox();
            this.EmployeePaygradeTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeDepartmentTextbox = new System.Windows.Forms.TextBox();
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
            this.addPayGradeTab = new System.Windows.Forms.TabPage();
            this.SaveGradebutton = new System.Windows.Forms.Button();
            this.OvertimetextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayTextBox = new System.Windows.Forms.TextBox();
            this.gradeNameTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.payRollInfoTab = new System.Windows.Forms.TabPage();
            this.ViewDepartmentButton = new System.Windows.Forms.Button();
            this.AddDepartmentbutton = new System.Windows.Forms.Button();
            this.homeTab.SuspendLayout();
            this.Home_Tab.SuspendLayout();
            this.AddEmployeeTab.SuspendLayout();
            this.ViewEmployeesTab.SuspendLayout();
            this.AddDepartmentTab.SuspendLayout();
            this.ViewDepartmentTab.SuspendLayout();
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
            this.homeTab.Location = new System.Drawing.Point(12, 12);
            this.homeTab.Name = "homeTab";
            this.homeTab.SelectedIndex = 0;
            this.homeTab.Size = new System.Drawing.Size(776, 441);
            this.homeTab.TabIndex = 0;
            // 
            // Home_Tab
            // 
            this.Home_Tab.Controls.Add(this.ViewDepartmentButton);
            this.Home_Tab.Controls.Add(this.AddDepartmentbutton);
            this.Home_Tab.Controls.Add(this.ViewEmployeesbutton);
            this.Home_Tab.Controls.Add(this.PayrollButton);
            this.Home_Tab.Controls.Add(this.ViewPayGradesbutton);
            this.Home_Tab.Controls.Add(this.addPaygradeButton);
            this.Home_Tab.Controls.Add(this.addEmployeebutton);
            this.Home_Tab.Location = new System.Drawing.Point(4, 24);
            this.Home_Tab.Name = "Home_Tab";
            this.Home_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Home_Tab.Size = new System.Drawing.Size(768, 413);
            this.Home_Tab.TabIndex = 0;
            this.Home_Tab.Text = "Home";
            this.Home_Tab.UseVisualStyleBackColor = true;
            // 
            // ViewEmployeesbutton
            // 
            this.ViewEmployeesbutton.Location = new System.Drawing.Point(323, 79);
            this.ViewEmployeesbutton.Name = "ViewEmployeesbutton";
            this.ViewEmployeesbutton.Size = new System.Drawing.Size(136, 29);
            this.ViewEmployeesbutton.TabIndex = 4;
            this.ViewEmployeesbutton.Text = "View Employees";
            this.ViewEmployeesbutton.UseVisualStyleBackColor = true;
            this.ViewEmployeesbutton.Click += new System.EventHandler(this.ViewEmployeesbutton_Click);
            // 
            // PayrollButton
            // 
            this.PayrollButton.Location = new System.Drawing.Point(97, 275);
            this.PayrollButton.Name = "PayrollButton";
            this.PayrollButton.Size = new System.Drawing.Size(133, 28);
            this.PayrollButton.TabIndex = 3;
            this.PayrollButton.Text = "Generate Payroll";
            this.PayrollButton.UseVisualStyleBackColor = true;
            this.PayrollButton.Click += new System.EventHandler(this.PayrollButton_Click);
            // 
            // ViewPayGradesbutton
            // 
            this.ViewPayGradesbutton.Location = new System.Drawing.Point(323, 151);
            this.ViewPayGradesbutton.Name = "ViewPayGradesbutton";
            this.ViewPayGradesbutton.Size = new System.Drawing.Size(136, 27);
            this.ViewPayGradesbutton.TabIndex = 2;
            this.ViewPayGradesbutton.Text = "View PayGrades";
            this.ViewPayGradesbutton.UseVisualStyleBackColor = true;
            this.ViewPayGradesbutton.Click += new System.EventHandler(this.ViewPayGradesbutton_Click);
            // 
            // addPaygradeButton
            // 
            this.addPaygradeButton.Location = new System.Drawing.Point(97, 151);
            this.addPaygradeButton.Name = "addPaygradeButton";
            this.addPaygradeButton.Size = new System.Drawing.Size(133, 27);
            this.addPaygradeButton.TabIndex = 1;
            this.addPaygradeButton.Text = "Add paygrade";
            this.addPaygradeButton.UseVisualStyleBackColor = true;
            this.addPaygradeButton.Click += new System.EventHandler(this.addPaygradeButton_Click);
            // 
            // addEmployeebutton
            // 
            this.addEmployeebutton.Location = new System.Drawing.Point(97, 79);
            this.addEmployeebutton.Name = "addEmployeebutton";
            this.addEmployeebutton.Size = new System.Drawing.Size(133, 29);
            this.addEmployeebutton.TabIndex = 0;
            this.addEmployeebutton.Text = "Add Employee";
            this.addEmployeebutton.UseVisualStyleBackColor = true;
            this.addEmployeebutton.Click += new System.EventHandler(this.addEmployeebutton_Click);
            // 
            // AddEmployeeTab
            // 
            this.AddEmployeeTab.Controls.Add(this.SaveEmployeeButton);
            this.AddEmployeeTab.Controls.Add(this.label7);
            this.AddEmployeeTab.Controls.Add(this.EmployeeGenderComboBox);
            this.AddEmployeeTab.Controls.Add(this.EmployeePaygradeTextBox);
            this.AddEmployeeTab.Controls.Add(this.EmployeeDepartmentTextbox);
            this.AddEmployeeTab.Controls.Add(this.EmployeeAgetextBox);
            this.AddEmployeeTab.Controls.Add(this.EmployeeLnametextBox);
            this.AddEmployeeTab.Controls.Add(this.EmployeeFnametextBox);
            this.AddEmployeeTab.Controls.Add(this.label6);
            this.AddEmployeeTab.Controls.Add(this.label5);
            this.AddEmployeeTab.Controls.Add(this.label4);
            this.AddEmployeeTab.Controls.Add(this.label3);
            this.AddEmployeeTab.Controls.Add(this.label2);
            this.AddEmployeeTab.Location = new System.Drawing.Point(4, 24);
            this.AddEmployeeTab.Name = "AddEmployeeTab";
            this.AddEmployeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddEmployeeTab.Size = new System.Drawing.Size(768, 413);
            this.AddEmployeeTab.TabIndex = 1;
            this.AddEmployeeTab.Text = "Add Employee";
            this.AddEmployeeTab.UseVisualStyleBackColor = true;
            // 
            // SaveEmployeeButton
            // 
            this.SaveEmployeeButton.Location = new System.Drawing.Point(205, 324);
            this.SaveEmployeeButton.Name = "SaveEmployeeButton";
            this.SaveEmployeeButton.Size = new System.Drawing.Size(120, 33);
            this.SaveEmployeeButton.TabIndex = 14;
            this.SaveEmployeeButton.Text = "Save";
            this.SaveEmployeeButton.UseVisualStyleBackColor = true;
            this.SaveEmployeeButton.Click += new System.EventHandler(this.SaveEmployeeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pay Grade";
            // 
            // EmployeeGenderComboBox
            // 
            this.EmployeeGenderComboBox.FormattingEnabled = true;
            this.EmployeeGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmployeeGenderComboBox.Location = new System.Drawing.Point(234, 127);
            this.EmployeeGenderComboBox.Name = "EmployeeGenderComboBox";
            this.EmployeeGenderComboBox.Size = new System.Drawing.Size(121, 23);
            this.EmployeeGenderComboBox.TabIndex = 12;
            // 
            // EmployeePaygradeTextBox
            // 
            this.EmployeePaygradeTextBox.Location = new System.Drawing.Point(234, 271);
            this.EmployeePaygradeTextBox.Name = "EmployeePaygradeTextBox";
            this.EmployeePaygradeTextBox.Size = new System.Drawing.Size(100, 23);
            this.EmployeePaygradeTextBox.TabIndex = 11;
            // 
            // EmployeeDepartmentTextbox
            // 
            this.EmployeeDepartmentTextbox.Location = new System.Drawing.Point(234, 218);
            this.EmployeeDepartmentTextbox.Name = "EmployeeDepartmentTextbox";
            this.EmployeeDepartmentTextbox.Size = new System.Drawing.Size(100, 23);
            this.EmployeeDepartmentTextbox.TabIndex = 10;
            // 
            // EmployeeAgetextBox
            // 
            this.EmployeeAgetextBox.Location = new System.Drawing.Point(234, 164);
            this.EmployeeAgetextBox.Name = "EmployeeAgetextBox";
            this.EmployeeAgetextBox.Size = new System.Drawing.Size(100, 23);
            this.EmployeeAgetextBox.TabIndex = 9;
            // 
            // EmployeeLnametextBox
            // 
            this.EmployeeLnametextBox.Location = new System.Drawing.Point(234, 91);
            this.EmployeeLnametextBox.Name = "EmployeeLnametextBox";
            this.EmployeeLnametextBox.Size = new System.Drawing.Size(100, 23);
            this.EmployeeLnametextBox.TabIndex = 8;
            // 
            // EmployeeFnametextBox
            // 
            this.EmployeeFnametextBox.Location = new System.Drawing.Point(234, 51);
            this.EmployeeFnametextBox.Name = "EmployeeFnametextBox";
            this.EmployeeFnametextBox.Size = new System.Drawing.Size(100, 23);
            this.EmployeeFnametextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // ViewEmployeesTab
            // 
            this.ViewEmployeesTab.Controls.Add(this.listViewEmployees);
            this.ViewEmployeesTab.Location = new System.Drawing.Point(4, 24);
            this.ViewEmployeesTab.Name = "ViewEmployeesTab";
            this.ViewEmployeesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewEmployeesTab.Size = new System.Drawing.Size(768, 413);
            this.ViewEmployeesTab.TabIndex = 2;
            this.ViewEmployeesTab.Text = "View Employees";
            this.ViewEmployeesTab.UseVisualStyleBackColor = true;
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.Age,
            this.Department,
            this.PayGrade});
            this.listViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEmployees.Location = new System.Drawing.Point(3, 3);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(762, 407);
            this.listViewEmployees.TabIndex = 1;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // AddDepartmentTab
            // 
            this.AddDepartmentTab.Controls.Add(this.DeptNametextBox);
            this.AddDepartmentTab.Controls.Add(this.SaveDepartmentbutton);
            this.AddDepartmentTab.Controls.Add(this.label10);
            this.AddDepartmentTab.Location = new System.Drawing.Point(4, 24);
            this.AddDepartmentTab.Name = "AddDepartmentTab";
            this.AddDepartmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddDepartmentTab.Size = new System.Drawing.Size(768, 413);
            this.AddDepartmentTab.TabIndex = 3;
            this.AddDepartmentTab.Text = "Add Department";
            this.AddDepartmentTab.UseVisualStyleBackColor = true;
            // 
            // DeptNametextBox
            // 
            this.DeptNametextBox.Location = new System.Drawing.Point(197, 105);
            this.DeptNametextBox.Name = "DeptNametextBox";
            this.DeptNametextBox.Size = new System.Drawing.Size(100, 23);
            this.DeptNametextBox.TabIndex = 8;
            // 
            // SaveDepartmentbutton
            // 
            this.SaveDepartmentbutton.Location = new System.Drawing.Point(211, 190);
            this.SaveDepartmentbutton.Name = "SaveDepartmentbutton";
            this.SaveDepartmentbutton.Size = new System.Drawing.Size(143, 29);
            this.SaveDepartmentbutton.TabIndex = 6;
            this.SaveDepartmentbutton.Text = "Save Department";
            this.SaveDepartmentbutton.UseVisualStyleBackColor = true;
            this.SaveDepartmentbutton.Click += new System.EventHandler(this.SaveDepartmentbutton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Department Name";
            // 
            // ViewDepartmentTab
            // 
            this.ViewDepartmentTab.Controls.Add(this.DepartmentlistView);
            this.ViewDepartmentTab.Location = new System.Drawing.Point(4, 24);
            this.ViewDepartmentTab.Name = "ViewDepartmentTab";
            this.ViewDepartmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewDepartmentTab.Size = new System.Drawing.Size(768, 413);
            this.ViewDepartmentTab.TabIndex = 4;
            this.ViewDepartmentTab.Text = "View Departments";
            this.ViewDepartmentTab.UseVisualStyleBackColor = true;
            // 
            // DepartmentlistView
            // 
            this.DepartmentlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DepartmentID,
            this.DepartmentName});
            this.DepartmentlistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentlistView.Location = new System.Drawing.Point(3, 3);
            this.DepartmentlistView.Name = "DepartmentlistView";
            this.DepartmentlistView.Size = new System.Drawing.Size(762, 407);
            this.DepartmentlistView.TabIndex = 2;
            this.DepartmentlistView.UseCompatibleStateImageBehavior = false;
            // 
            // viewPayGradeTab
            // 
            this.viewPayGradeTab.Location = new System.Drawing.Point(4, 24);
            this.viewPayGradeTab.Name = "viewPayGradeTab";
            this.viewPayGradeTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewPayGradeTab.Size = new System.Drawing.Size(768, 413);
            this.viewPayGradeTab.TabIndex = 5;
            this.viewPayGradeTab.Text = "View Pay Grades";
            this.viewPayGradeTab.UseVisualStyleBackColor = true;
            // 
            // addPayGradeTab
            // 
            this.addPayGradeTab.Controls.Add(this.SaveGradebutton);
            this.addPayGradeTab.Controls.Add(this.OvertimetextBox);
            this.addPayGradeTab.Controls.Add(this.hourlyPayTextBox);
            this.addPayGradeTab.Controls.Add(this.gradeNameTextbox);
            this.addPayGradeTab.Controls.Add(this.label11);
            this.addPayGradeTab.Controls.Add(this.label12);
            this.addPayGradeTab.Controls.Add(this.label13);
            this.addPayGradeTab.Location = new System.Drawing.Point(4, 24);
            this.addPayGradeTab.Name = "addPayGradeTab";
            this.addPayGradeTab.Padding = new System.Windows.Forms.Padding(3);
            this.addPayGradeTab.Size = new System.Drawing.Size(768, 413);
            this.addPayGradeTab.TabIndex = 6;
            this.addPayGradeTab.Text = "Add Pay Grades";
            this.addPayGradeTab.UseVisualStyleBackColor = true;
            // 
            // SaveGradebutton
            // 
            this.SaveGradebutton.Location = new System.Drawing.Point(191, 237);
            this.SaveGradebutton.Name = "SaveGradebutton";
            this.SaveGradebutton.Size = new System.Drawing.Size(120, 33);
            this.SaveGradebutton.TabIndex = 22;
            this.SaveGradebutton.Text = "Save";
            this.SaveGradebutton.UseVisualStyleBackColor = true;
            this.SaveGradebutton.Click += new System.EventHandler(this.SaveGradebutton_Click);
            // 
            // OvertimetextBox
            // 
            this.OvertimetextBox.Location = new System.Drawing.Point(265, 172);
            this.OvertimetextBox.Name = "OvertimetextBox";
            this.OvertimetextBox.Size = new System.Drawing.Size(100, 23);
            this.OvertimetextBox.TabIndex = 21;
            // 
            // hourlyPayTextBox
            // 
            this.hourlyPayTextBox.Location = new System.Drawing.Point(265, 133);
            this.hourlyPayTextBox.Name = "hourlyPayTextBox";
            this.hourlyPayTextBox.Size = new System.Drawing.Size(100, 23);
            this.hourlyPayTextBox.TabIndex = 20;
            // 
            // gradeNameTextbox
            // 
            this.gradeNameTextbox.Location = new System.Drawing.Point(265, 93);
            this.gradeNameTextbox.Name = "gradeNameTextbox";
            this.gradeNameTextbox.Size = new System.Drawing.Size(100, 23);
            this.gradeNameTextbox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Overtime pay";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(125, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Hourly Pay";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(125, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Grade Name";
            // 
            // payRollInfoTab
            // 
            this.payRollInfoTab.Location = new System.Drawing.Point(4, 24);
            this.payRollInfoTab.Name = "payRollInfoTab";
            this.payRollInfoTab.Size = new System.Drawing.Size(768, 413);
            this.payRollInfoTab.TabIndex = 7;
            this.payRollInfoTab.Text = "Payroll Info";
            this.payRollInfoTab.UseVisualStyleBackColor = true;
            // 
            // ViewDepartmentButton
            // 
            this.ViewDepartmentButton.Location = new System.Drawing.Point(323, 216);
            this.ViewDepartmentButton.Name = "ViewDepartmentButton";
            this.ViewDepartmentButton.Size = new System.Drawing.Size(136, 29);
            this.ViewDepartmentButton.TabIndex = 6;
            this.ViewDepartmentButton.Text = "View Departments";
            this.ViewDepartmentButton.UseVisualStyleBackColor = true;
            this.ViewDepartmentButton.Click += new System.EventHandler(this.ViewDepartmentButton_Click);
            // 
            // AddDepartmentbutton
            // 
            this.AddDepartmentbutton.Location = new System.Drawing.Point(97, 216);
            this.AddDepartmentbutton.Name = "AddDepartmentbutton";
            this.AddDepartmentbutton.Size = new System.Drawing.Size(133, 29);
            this.AddDepartmentbutton.TabIndex = 5;
            this.AddDepartmentbutton.Text = "Add Department";
            this.AddDepartmentbutton.UseVisualStyleBackColor = true;
            this.AddDepartmentbutton.Click += new System.EventHandler(this.AddDepartmentbutton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homeTab);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.homeTab.ResumeLayout(false);
            this.Home_Tab.ResumeLayout(false);
            this.AddEmployeeTab.ResumeLayout(false);
            this.AddEmployeeTab.PerformLayout();
            this.ViewEmployeesTab.ResumeLayout(false);
            this.AddDepartmentTab.ResumeLayout(false);
            this.AddDepartmentTab.PerformLayout();
            this.ViewDepartmentTab.ResumeLayout(false);
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
        private TextBox EmployeePaygradeTextBox;
        private TextBox EmployeeDepartmentTextbox;
        private TextBox EmployeeAgetextBox;
        private TextBox EmployeeLnametextBox;
        private TextBox EmployeeFnametextBox;
        private TextBox EmployeeIDtextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
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
    }
}