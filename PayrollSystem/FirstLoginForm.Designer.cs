namespace PayrollSystem
{
    partial class FirstLoginForm
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
            this.Employeebutton = new System.Windows.Forms.Button();
            this.Adminbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Employeebutton
            // 
            this.Employeebutton.Location = new System.Drawing.Point(321, 108);
            this.Employeebutton.Name = "Employeebutton";
            this.Employeebutton.Size = new System.Drawing.Size(143, 36);
            this.Employeebutton.TabIndex = 0;
            this.Employeebutton.Text = "Login as Employee";
            this.Employeebutton.UseVisualStyleBackColor = true;
            this.Employeebutton.Click += new System.EventHandler(this.Employeebutton_Click);
            // 
            // Adminbutton
            // 
            this.Adminbutton.Location = new System.Drawing.Point(321, 187);
            this.Adminbutton.Name = "Adminbutton";
            this.Adminbutton.Size = new System.Drawing.Size(143, 36);
            this.Adminbutton.TabIndex = 1;
            this.Adminbutton.Text = "Login as Administrator";
            this.Adminbutton.UseVisualStyleBackColor = true;
            this.Adminbutton.Click += new System.EventHandler(this.Adminbutton_Click);
            // 
            // FirstLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Adminbutton);
            this.Controls.Add(this.Employeebutton);
            this.Name = "FirstLoginForm";
            this.Text = "Login Page";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Employeebutton;
        private Button Adminbutton;
    }
}