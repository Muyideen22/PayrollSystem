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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewEmployeesTab = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.Gender = new System.Windows.Forms.ColumnHeader();
            this.Age = new System.Windows.Forms.ColumnHeader();
            this.Department = new System.Windows.Forms.ColumnHeader();
            this.PayGrade = new System.Windows.Forms.ColumnHeader();
            this.AddDepartmentTab = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ViewDepartmentTab = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.DepartmentID = new System.Windows.Forms.ColumnHeader();
            this.DepartmentName = new System.Windows.Forms.ColumnHeader();
            this.viewPayGradeTab = new System.Windows.Forms.TabPage();
            this.addPayGradeTab = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.payRollInfoTab = new System.Windows.Forms.TabPage();
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
            this.PayrollButton.Location = new System.Drawing.Point(97, 212);
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
            this.AddEmployeeTab.Controls.Add(this.button1);
            this.AddEmployeeTab.Controls.Add(this.label7);
            this.AddEmployeeTab.Controls.Add(this.comboBox1);
            this.AddEmployeeTab.Controls.Add(this.textBox6);
            this.AddEmployeeTab.Controls.Add(this.textBox5);
            this.AddEmployeeTab.Controls.Add(this.textBox4);
            this.AddEmployeeTab.Controls.Add(this.textBox3);
            this.AddEmployeeTab.Controls.Add(this.textBox2);
            this.AddEmployeeTab.Controls.Add(this.textBox1);
            this.AddEmployeeTab.Controls.Add(this.label6);
            this.AddEmployeeTab.Controls.Add(this.label5);
            this.AddEmployeeTab.Controls.Add(this.label4);
            this.AddEmployeeTab.Controls.Add(this.label3);
            this.AddEmployeeTab.Controls.Add(this.label2);
            this.AddEmployeeTab.Controls.Add(this.label1);
            this.AddEmployeeTab.Location = new System.Drawing.Point(4, 24);
            this.AddEmployeeTab.Name = "AddEmployeeTab";
            this.AddEmployeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddEmployeeTab.Size = new System.Drawing.Size(768, 413);
            this.AddEmployeeTab.TabIndex = 1;
            this.AddEmployeeTab.Text = "Add Employee";
            this.AddEmployeeTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pay Grade";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(223, 316);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(223, 263);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(223, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // ViewEmployeesTab
            // 
            this.ViewEmployeesTab.Controls.Add(this.listView1);
            this.ViewEmployeesTab.Location = new System.Drawing.Point(4, 24);
            this.ViewEmployeesTab.Name = "ViewEmployeesTab";
            this.ViewEmployeesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewEmployeesTab.Size = new System.Drawing.Size(768, 413);
            this.ViewEmployeesTab.TabIndex = 2;
            this.ViewEmployeesTab.Text = "View Employees";
            this.ViewEmployeesTab.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.Age,
            this.Department,
            this.PayGrade});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(762, 407);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AddDepartmentTab
            // 
            this.AddDepartmentTab.Controls.Add(this.textBox8);
            this.AddDepartmentTab.Controls.Add(this.textBox7);
            this.AddDepartmentTab.Controls.Add(this.button7);
            this.AddDepartmentTab.Controls.Add(this.label10);
            this.AddDepartmentTab.Controls.Add(this.label8);
            this.AddDepartmentTab.Location = new System.Drawing.Point(4, 24);
            this.AddDepartmentTab.Name = "AddDepartmentTab";
            this.AddDepartmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddDepartmentTab.Size = new System.Drawing.Size(768, 413);
            this.AddDepartmentTab.TabIndex = 3;
            this.AddDepartmentTab.Text = "Add Department";
            this.AddDepartmentTab.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(197, 105);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(197, 52);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(211, 190);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 29);
            this.button7.TabIndex = 6;
            this.button7.Text = "Save Department";
            this.button7.UseVisualStyleBackColor = true;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Department ID";
            // 
            // ViewDepartmentTab
            // 
            this.ViewDepartmentTab.Controls.Add(this.listView2);
            this.ViewDepartmentTab.Location = new System.Drawing.Point(4, 24);
            this.ViewDepartmentTab.Name = "ViewDepartmentTab";
            this.ViewDepartmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewDepartmentTab.Size = new System.Drawing.Size(768, 413);
            this.ViewDepartmentTab.TabIndex = 4;
            this.ViewDepartmentTab.Text = "View Departments";
            this.ViewDepartmentTab.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DepartmentID,
            this.DepartmentName});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(762, 407);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
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
            this.addPayGradeTab.Controls.Add(this.button6);
            this.addPayGradeTab.Controls.Add(this.textBox9);
            this.addPayGradeTab.Controls.Add(this.textBox10);
            this.addPayGradeTab.Controls.Add(this.textBox11);
            this.addPayGradeTab.Controls.Add(this.textBox12);
            this.addPayGradeTab.Controls.Add(this.label11);
            this.addPayGradeTab.Controls.Add(this.label12);
            this.addPayGradeTab.Controls.Add(this.label13);
            this.addPayGradeTab.Controls.Add(this.label14);
            this.addPayGradeTab.Location = new System.Drawing.Point(4, 24);
            this.addPayGradeTab.Name = "addPayGradeTab";
            this.addPayGradeTab.Padding = new System.Windows.Forms.Padding(3);
            this.addPayGradeTab.Size = new System.Drawing.Size(768, 413);
            this.addPayGradeTab.TabIndex = 6;
            this.addPayGradeTab.Text = "Add Pay Grades";
            this.addPayGradeTab.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(191, 237);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 33);
            this.button6.TabIndex = 22;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(265, 172);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 23);
            this.textBox9.TabIndex = 21;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(265, 133);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 23);
            this.textBox10.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(265, 93);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 23);
            this.textBox11.TabIndex = 19;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(265, 48);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 23);
            this.textBox12.TabIndex = 18;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Grade ID";
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
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label7;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Gender;
        private ColumnHeader Age;
        private ColumnHeader Department;
        private ColumnHeader PayGrade;
        private TabPage AddDepartmentTab;
        private Label label10;
        private Label label8;
        private TextBox textBox8;
        private TextBox textBox7;
        private Button button7;
        private TabPage ViewDepartmentTab;
        private ListView listView2;
        private ColumnHeader DepartmentID;
        private ColumnHeader DepartmentName;
        private TabPage viewPayGradeTab;
        private TabPage addPayGradeTab;
        private TabPage payRollInfoTab;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button button6;
    }
}