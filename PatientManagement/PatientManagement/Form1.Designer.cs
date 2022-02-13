
namespace PatientManagement
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.ExitLbl = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.ExitLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Management System";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Maroon;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginBtn.Location = new System.Drawing.Point(154, 309);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(154, 40);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserNametxt
            // 
            this.UserNametxt.ForeColor = System.Drawing.Color.Black;
            this.UserNametxt.Location = new System.Drawing.Point(154, 199);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(154, 22);
            this.UserNametxt.TabIndex = 2;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.ForeColor = System.Drawing.Color.Black;
            this.Passwordtxt.Location = new System.Drawing.Point(154, 255);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(154, 22);
            this.Passwordtxt.TabIndex = 3;
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.ForeColor = System.Drawing.Color.Black;
            this.UserNameLbl.Location = new System.Drawing.Point(41, 202);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(79, 17);
            this.UserNameLbl.TabIndex = 4;
            this.UserNameLbl.Text = "User Name";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.ForeColor = System.Drawing.Color.Black;
            this.PasswordLbl.Location = new System.Drawing.Point(51, 258);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(69, 17);
            this.PasswordLbl.TabIndex = 5;
            this.PasswordLbl.Text = "Password";
            // 
            // ExitLbl
            // 
            this.ExitLbl.AutoSize = true;
            this.ExitLbl.BackColor = System.Drawing.Color.Maroon;
            this.ExitLbl.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitLbl.Location = new System.Drawing.Point(347, 0);
            this.ExitLbl.Name = "ExitLbl";
            this.ExitLbl.Size = new System.Drawing.Size(30, 27);
            this.ExitLbl.TabIndex = 5;
            this.ExitLbl.Text = "X";
            this.ExitLbl.Click += new System.EventHandler(this.ExitLbl_Click);
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Recieptionist"});
            this.roleComboBox.Location = new System.Drawing.Point(154, 154);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(154, 24);
            this.roleComboBox.TabIndex = 6;
            this.roleComboBox.Text = "Select";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Role";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(377, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.UserNametxt);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label ExitLbl;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label2;
    }
}

