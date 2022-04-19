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
            this.button5 = new System.Windows.Forms.Button();
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
            this.attendanceTab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LeaveTab = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
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
            this.EmployeeHomeTab.Location = new System.Drawing.Point(12, 12);
            this.EmployeeHomeTab.Name = "EmployeeHomeTab";
            this.EmployeeHomeTab.SelectedIndex = 0;
            this.EmployeeHomeTab.Size = new System.Drawing.Size(776, 436);
            this.EmployeeHomeTab.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.LeaveButton);
            this.HomeTab.Controls.Add(this.AddAttendancebutton);
            this.HomeTab.Controls.Add(this.UpdteDetailsbutton);
            this.HomeTab.Location = new System.Drawing.Point(4, 24);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(768, 408);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(147, 259);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(155, 43);
            this.LeaveButton.TabIndex = 3;
            this.LeaveButton.Text = "Request Leave";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // AddAttendancebutton
            // 
            this.AddAttendancebutton.Location = new System.Drawing.Point(147, 162);
            this.AddAttendancebutton.Name = "AddAttendancebutton";
            this.AddAttendancebutton.Size = new System.Drawing.Size(155, 43);
            this.AddAttendancebutton.TabIndex = 1;
            this.AddAttendancebutton.Text = "Add attendance";
            this.AddAttendancebutton.UseVisualStyleBackColor = true;
            this.AddAttendancebutton.Click += new System.EventHandler(this.AddAttendancebutton_Click);
            // 
            // UpdteDetailsbutton
            // 
            this.UpdteDetailsbutton.Location = new System.Drawing.Point(147, 68);
            this.UpdteDetailsbutton.Name = "UpdteDetailsbutton";
            this.UpdteDetailsbutton.Size = new System.Drawing.Size(155, 53);
            this.UpdteDetailsbutton.TabIndex = 0;
            this.UpdteDetailsbutton.Text = "Update My Details";
            this.UpdteDetailsbutton.UseVisualStyleBackColor = true;
            this.UpdteDetailsbutton.Click += new System.EventHandler(this.UpdteDetailsbutton_Click);
            // 
            // DetailsTab
            // 
            this.DetailsTab.Controls.Add(this.button5);
            this.DetailsTab.Controls.Add(this.label7);
            this.DetailsTab.Controls.Add(this.comboBox1);
            this.DetailsTab.Controls.Add(this.textBox6);
            this.DetailsTab.Controls.Add(this.textBox5);
            this.DetailsTab.Controls.Add(this.textBox4);
            this.DetailsTab.Controls.Add(this.textBox3);
            this.DetailsTab.Controls.Add(this.textBox2);
            this.DetailsTab.Controls.Add(this.textBox1);
            this.DetailsTab.Controls.Add(this.label6);
            this.DetailsTab.Controls.Add(this.label5);
            this.DetailsTab.Controls.Add(this.label4);
            this.DetailsTab.Controls.Add(this.label3);
            this.DetailsTab.Controls.Add(this.label2);
            this.DetailsTab.Controls.Add(this.label1);
            this.DetailsTab.Location = new System.Drawing.Point(4, 24);
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailsTab.Size = new System.Drawing.Size(768, 408);
            this.DetailsTab.TabIndex = 1;
            this.DetailsTab.Text = "My Details";
            this.DetailsTab.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(365, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 33);
            this.button5.TabIndex = 29;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Pay Grade";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(394, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(394, 294);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(394, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(394, 187);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(394, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(394, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // attendanceTab
            // 
            this.attendanceTab.Controls.Add(this.button3);
            this.attendanceTab.Controls.Add(this.dateTimePicker2);
            this.attendanceTab.Controls.Add(this.dateTimePicker1);
            this.attendanceTab.Controls.Add(this.textBox10);
            this.attendanceTab.Controls.Add(this.label11);
            this.attendanceTab.Controls.Add(this.textBox7);
            this.attendanceTab.Controls.Add(this.label8);
            this.attendanceTab.Controls.Add(this.label9);
            this.attendanceTab.Controls.Add(this.label10);
            this.attendanceTab.Location = new System.Drawing.Point(4, 24);
            this.attendanceTab.Name = "attendanceTab";
            this.attendanceTab.Size = new System.Drawing.Size(768, 408);
            this.attendanceTab.TabIndex = 2;
            this.attendanceTab.Text = "Weekly attendance";
            this.attendanceTab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 33);
            this.button3.TabIndex = 34;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(292, 130);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(292, 211);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 23);
            this.textBox10.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Overtime hours worked:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(292, 173);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Regular hours worked:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "End Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Start Date";
            // 
            // LeaveTab
            // 
            this.LeaveTab.Controls.Add(this.button6);
            this.LeaveTab.Controls.Add(this.textBox8);
            this.LeaveTab.Controls.Add(this.label14);
            this.LeaveTab.Controls.Add(this.dateTimePicker3);
            this.LeaveTab.Controls.Add(this.dateTimePicker4);
            this.LeaveTab.Controls.Add(this.label12);
            this.LeaveTab.Controls.Add(this.label13);
            this.LeaveTab.Location = new System.Drawing.Point(4, 24);
            this.LeaveTab.Name = "LeaveTab";
            this.LeaveTab.Size = new System.Drawing.Size(768, 408);
            this.LeaveTab.TabIndex = 3;
            this.LeaveTab.Text = "Request Leave";
            this.LeaveTab.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(279, 237);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 33);
            this.button6.TabIndex = 40;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(279, 169);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(101, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 15);
            this.label14.TabIndex = 38;
            this.label14.Text = "Reason for leave request";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(279, 119);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker3.TabIndex = 37;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(279, 68);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker4.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "End Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "Start Date";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeHomeTab);
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
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
        private Button button5;
        private Label label7;
        private ComboBox comboBox1;
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
        private TabPage attendanceTab;
        private TabPage LeaveTab;
        private TextBox textBox7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox10;
        private Label label11;
        private Button button3;
        private Button button6;
        private TextBox textBox8;
        private Label label14;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Label label12;
        private Label label13;
    }
}