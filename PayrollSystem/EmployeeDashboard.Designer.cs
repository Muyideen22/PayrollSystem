namespace PayrollSystem
{
    partial class EmployeeDashboard
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
        public int EmployeeID { get; set; }
        private DatabaseConnectionWrapper databaseConnectionWrapper = new();
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeHomeTab = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.AddAttendancebutton = new System.Windows.Forms.Button();
            this.UpdteDetailsbutton = new System.Windows.Forms.Button();
            this.DetailsTab = new System.Windows.Forms.TabPage();
            this.PayGradeComboBox = new System.Windows.Forms.ComboBox();
            this.DepartmentcomboBox = new System.Windows.Forms.ComboBox();
            this.SaveDetailsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.GenderSelect = new System.Windows.Forms.ComboBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.LnameTextBox = new System.Windows.Forms.TextBox();
            this.FnameTextBox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attendanceTab = new System.Windows.Forms.TabPage();
            this.SaveAttendanceButton = new System.Windows.Forms.Button();
            this.weeklyEndDate = new System.Windows.Forms.DateTimePicker();
            this.weeklyStartDate = new System.Windows.Forms.DateTimePicker();
            this.OvertimeHours = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RegularHours = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LeaveTab = new System.Windows.Forms.TabPage();
            this.SaveLeavebutton = new System.Windows.Forms.Button();
            this.ReasontextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EmployeeHomeTab.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.DetailsTab.SuspendLayout();
            this.attendanceTab.SuspendLayout();
            this.LeaveTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeHomeTab
            // 
            this.EmployeeHomeTab.Controls.Add(this.HomeTab);
            this.EmployeeHomeTab.Controls.Add(this.DetailsTab);
            this.EmployeeHomeTab.Controls.Add(this.attendanceTab);
            this.EmployeeHomeTab.Controls.Add(this.LeaveTab);
            this.EmployeeHomeTab.Location = new System.Drawing.Point(40, 38);
            this.EmployeeHomeTab.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.EmployeeHomeTab.Name = "EmployeeHomeTab";
            this.EmployeeHomeTab.SelectedIndex = 0;
            this.EmployeeHomeTab.Size = new System.Drawing.Size(2567, 1390);
            this.EmployeeHomeTab.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HomeTab.Controls.Add(this.LeaveButton);
            this.HomeTab.Controls.Add(this.AddAttendancebutton);
            this.HomeTab.Controls.Add(this.UpdteDetailsbutton);
            this.HomeTab.Location = new System.Drawing.Point(8, 59);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.HomeTab.Size = new System.Drawing.Size(2551, 1323);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(486, 826);
            this.LeaveButton.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(513, 137);
            this.LeaveButton.TabIndex = 3;
            this.LeaveButton.Text = "Request Leave";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // AddAttendancebutton
            // 
            this.AddAttendancebutton.Location = new System.Drawing.Point(486, 516);
            this.AddAttendancebutton.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.AddAttendancebutton.Name = "AddAttendancebutton";
            this.AddAttendancebutton.Size = new System.Drawing.Size(513, 137);
            this.AddAttendancebutton.TabIndex = 1;
            this.AddAttendancebutton.Text = "Add attendance";
            this.AddAttendancebutton.UseVisualStyleBackColor = true;
            this.AddAttendancebutton.Click += new System.EventHandler(this.AddAttendancebutton_Click);
            // 
            // UpdteDetailsbutton
            // 
            this.UpdteDetailsbutton.Location = new System.Drawing.Point(486, 217);
            this.UpdteDetailsbutton.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.UpdteDetailsbutton.Name = "UpdteDetailsbutton";
            this.UpdteDetailsbutton.Size = new System.Drawing.Size(513, 169);
            this.UpdteDetailsbutton.TabIndex = 0;
            this.UpdteDetailsbutton.Text = "Update My Details";
            this.UpdteDetailsbutton.UseVisualStyleBackColor = true;
            this.UpdteDetailsbutton.Click += new System.EventHandler(this.UpdteDetailsbutton_Click);
            // 
            // DetailsTab
            // 
            this.DetailsTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DetailsTab.Controls.Add(this.PayGradeComboBox);
            this.DetailsTab.Controls.Add(this.DepartmentcomboBox);
            this.DetailsTab.Controls.Add(this.SaveDetailsButton);
            this.DetailsTab.Controls.Add(this.label7);
            this.DetailsTab.Controls.Add(this.GenderSelect);
            this.DetailsTab.Controls.Add(this.AgeTextBox);
            this.DetailsTab.Controls.Add(this.LnameTextBox);
            this.DetailsTab.Controls.Add(this.FnameTextBox);
            this.DetailsTab.Controls.Add(this.IDtextBox);
            this.DetailsTab.Controls.Add(this.label6);
            this.DetailsTab.Controls.Add(this.label5);
            this.DetailsTab.Controls.Add(this.label4);
            this.DetailsTab.Controls.Add(this.label3);
            this.DetailsTab.Controls.Add(this.label2);
            this.DetailsTab.Controls.Add(this.label1);
            this.DetailsTab.Location = new System.Drawing.Point(8, 116);
            this.DetailsTab.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.Padding = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.DetailsTab.Size = new System.Drawing.Size(2551, 1266);
            this.DetailsTab.TabIndex = 1;
            this.DetailsTab.Text = "My Details";
            // 
            // PayGradeComboBox
            // 
            this.PayGradeComboBox.FormattingEnabled = true;
            this.PayGradeComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PayGradeComboBox.Location = new System.Drawing.Point(1303, 963);
            this.PayGradeComboBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.PayGradeComboBox.Name = "PayGradeComboBox";
            this.PayGradeComboBox.Size = new System.Drawing.Size(391, 53);
            this.PayGradeComboBox.TabIndex = 31;
            // 
            // DepartmentcomboBox
            // 
            this.DepartmentcomboBox.FormattingEnabled = true;
            this.DepartmentcomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DepartmentcomboBox.Location = new System.Drawing.Point(1303, 778);
            this.DepartmentcomboBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.DepartmentcomboBox.Name = "DepartmentcomboBox";
            this.DepartmentcomboBox.Size = new System.Drawing.Size(391, 53);
            this.DepartmentcomboBox.TabIndex = 30;
            // 
            // SaveDetailsButton
            // 
            this.SaveDetailsButton.Location = new System.Drawing.Point(1207, 1106);
            this.SaveDetailsButton.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.SaveDetailsButton.Name = "SaveDetailsButton";
            this.SaveDetailsButton.Size = new System.Drawing.Size(397, 105);
            this.SaveDetailsButton.TabIndex = 29;
            this.SaveDetailsButton.Text = "Save";
            this.SaveDetailsButton.UseVisualStyleBackColor = true;
            this.SaveDetailsButton.Click += new System.EventHandler(this.SaveDetailsButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(840, 963);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 45);
            this.label7.TabIndex = 28;
            this.label7.Text = "Pay Grade";
            // 
            // GenderSelect
            // 
            this.GenderSelect.FormattingEnabled = true;
            this.GenderSelect.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderSelect.Location = new System.Drawing.Point(1303, 478);
            this.GenderSelect.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.GenderSelect.Name = "GenderSelect";
            this.GenderSelect.Size = new System.Drawing.Size(391, 53);
            this.GenderSelect.TabIndex = 27;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(1303, 596);
            this.AgeTextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(322, 50);
            this.AgeTextBox.TabIndex = 24;
            // 
            // LnameTextBox
            // 
            this.LnameTextBox.Location = new System.Drawing.Point(1303, 363);
            this.LnameTextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(322, 50);
            this.LnameTextBox.TabIndex = 23;
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.Location = new System.Drawing.Point(1303, 236);
            this.FnameTextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(322, 50);
            this.FnameTextBox.TabIndex = 22;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(1303, 92);
            this.IDtextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(322, 50);
            this.IDtextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(840, 778);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 45);
            this.label6.TabIndex = 20;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(840, 606);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 45);
            this.label5.TabIndex = 19;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(840, 488);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 45);
            this.label4.TabIndex = 18;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(840, 373);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 45);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(840, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 45);
            this.label2.TabIndex = 16;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(840, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // attendanceTab
            // 
            this.attendanceTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.attendanceTab.Controls.Add(this.SaveAttendanceButton);
            this.attendanceTab.Controls.Add(this.weeklyEndDate);
            this.attendanceTab.Controls.Add(this.weeklyStartDate);
            this.attendanceTab.Controls.Add(this.OvertimeHours);
            this.attendanceTab.Controls.Add(this.label11);
            this.attendanceTab.Controls.Add(this.RegularHours);
            this.attendanceTab.Controls.Add(this.label8);
            this.attendanceTab.Controls.Add(this.label9);
            this.attendanceTab.Controls.Add(this.label10);
            this.attendanceTab.Location = new System.Drawing.Point(8, 116);
            this.attendanceTab.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.attendanceTab.Name = "attendanceTab";
            this.attendanceTab.Size = new System.Drawing.Size(2551, 1266);
            this.attendanceTab.TabIndex = 2;
            this.attendanceTab.Text = "Weekly attendance";
            // 
            // SaveAttendanceButton
            // 
            this.SaveAttendanceButton.Location = new System.Drawing.Point(966, 889);
            this.SaveAttendanceButton.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.SaveAttendanceButton.Name = "SaveAttendanceButton";
            this.SaveAttendanceButton.Size = new System.Drawing.Size(397, 105);
            this.SaveAttendanceButton.TabIndex = 34;
            this.SaveAttendanceButton.Text = "Save";
            this.SaveAttendanceButton.UseVisualStyleBackColor = true;
            this.SaveAttendanceButton.Click += new System.EventHandler(this.SaveAttendanceButton_Click);
            // 
            // weeklyEndDate
            // 
            this.weeklyEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.weeklyEndDate.Location = new System.Drawing.Point(966, 414);
            this.weeklyEndDate.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.weeklyEndDate.Name = "weeklyEndDate";
            this.weeklyEndDate.Size = new System.Drawing.Size(652, 50);
            this.weeklyEndDate.TabIndex = 33;
            // 
            // weeklyStartDate
            // 
            this.weeklyStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.weeklyStartDate.Location = new System.Drawing.Point(966, 252);
            this.weeklyStartDate.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.weeklyStartDate.Name = "weeklyStartDate";
            this.weeklyStartDate.Size = new System.Drawing.Size(652, 50);
            this.weeklyStartDate.TabIndex = 32;
            // 
            // OvertimeHours
            // 
            this.OvertimeHours.Location = new System.Drawing.Point(966, 673);
            this.OvertimeHours.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.OvertimeHours.Name = "OvertimeHours";
            this.OvertimeHours.Size = new System.Drawing.Size(322, 50);
            this.OvertimeHours.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 682);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(361, 45);
            this.label11.TabIndex = 30;
            this.label11.Text = "Overtime hours worked:";
            // 
            // RegularHours
            // 
            this.RegularHours.Location = new System.Drawing.Point(966, 551);
            this.RegularHours.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.RegularHours.Name = "RegularHours";
            this.RegularHours.Size = new System.Drawing.Size(322, 50);
            this.RegularHours.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 551);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(337, 45);
            this.label8.TabIndex = 26;
            this.label8.Text = "Regular hours worked:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 414);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 45);
            this.label9.TabIndex = 25;
            this.label9.Text = "End Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 271);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 45);
            this.label10.TabIndex = 24;
            this.label10.Text = "Start Date";
            // 
            // LeaveTab
            // 
            this.LeaveTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LeaveTab.Controls.Add(this.SaveLeavebutton);
            this.LeaveTab.Controls.Add(this.ReasontextBox);
            this.LeaveTab.Controls.Add(this.label14);
            this.LeaveTab.Controls.Add(this.endDate);
            this.LeaveTab.Controls.Add(this.startDate);
            this.LeaveTab.Controls.Add(this.label12);
            this.LeaveTab.Controls.Add(this.label13);
            this.LeaveTab.Location = new System.Drawing.Point(8, 116);
            this.LeaveTab.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.LeaveTab.Name = "LeaveTab";
            this.LeaveTab.Size = new System.Drawing.Size(2551, 1266);
            this.LeaveTab.TabIndex = 3;
            this.LeaveTab.Text = "Request Leave";
            // 
            // SaveLeavebutton
            // 
            this.SaveLeavebutton.Location = new System.Drawing.Point(923, 956);
            this.SaveLeavebutton.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.SaveLeavebutton.Name = "SaveLeavebutton";
            this.SaveLeavebutton.Size = new System.Drawing.Size(397, 105);
            this.SaveLeavebutton.TabIndex = 40;
            this.SaveLeavebutton.Text = "Save";
            this.SaveLeavebutton.UseVisualStyleBackColor = true;
            this.SaveLeavebutton.Click += new System.EventHandler(this.SaveLeavebutton_Click);
            // 
            // ReasontextBox
            // 
            this.ReasontextBox.Location = new System.Drawing.Point(923, 539);
            this.ReasontextBox.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.ReasontextBox.Multiline = true;
            this.ReasontextBox.Name = "ReasontextBox";
            this.ReasontextBox.Size = new System.Drawing.Size(1000, 291);
            this.ReasontextBox.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(331, 634);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(369, 45);
            this.label14.TabIndex = 38;
            this.label14.Text = "Reason for leave request";
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(923, 379);
            this.endDate.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(652, 50);
            this.endDate.TabIndex = 37;
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(923, 217);
            this.startDate.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(652, 50);
            this.startDate.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 379);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 45);
            this.label12.TabIndex = 35;
            this.label12.Text = "End Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 236);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 45);
            this.label13.TabIndex = 34;
            this.label13.Text = "Start Date";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2646, 1434);
            this.Controls.Add(this.EmployeeHomeTab);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.Name = "EmployeeDashboard";
            this.Text = "Employee Dashboard";
            this.EmployeeHomeTab.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.DetailsTab.ResumeLayout(false);
            this.DetailsTab.PerformLayout();
            this.attendanceTab.ResumeLayout(false);
            this.attendanceTab.PerformLayout();
            this.LeaveTab.ResumeLayout(false);
            this.LeaveTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EmployeeHomeTab;
        private TabPage HomeTab;
        private Button LeaveButton;
        private Button AddAttendancebutton;
        private Button UpdteDetailsbutton;
        private TabPage DetailsTab;
        private Button SaveDetailsButton;
        private Label label7;
        private ComboBox GenderSelect;
        private TextBox AgeTextBox;
        private TextBox LnameTextBox;
        private TextBox FnameTextBox;
        private TextBox IDtextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage attendanceTab;
        private TabPage LeaveTab;
        private TextBox RegularHours;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker weeklyEndDate;
        private DateTimePicker weeklyStartDate;
        private TextBox OvertimeHours;
        private Label label11;
        private Button SaveAttendanceButton;
        private Button SaveLeavebutton;
        private TextBox ReasontextBox;
        private Label label14;
        private DateTimePicker endDate;
        private DateTimePicker startDate;
        private Label label12;
        private Label label13;
        private ComboBox PayGradeComboBox;
        private ComboBox DepartmentcomboBox;
    }
}