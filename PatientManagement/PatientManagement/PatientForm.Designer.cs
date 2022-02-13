
namespace PatientManagement
{
    partial class PatientForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PatName = new System.Windows.Forms.TextBox();
            this.PatAddress = new System.Windows.Forms.TextBox();
            this.PatContact = new System.Windows.Forms.TextBox();
            this.PatAge = new System.Windows.Forms.TextBox();
            this.PatGenderCb = new System.Windows.Forms.ComboBox();
            this.PatBloodCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PatDisease = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PatientGV = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.ExitLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.ExitLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 83);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(319, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "PATIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // PatId
            // 
            this.PatId.BackColor = System.Drawing.Color.Gainsboro;
            this.PatId.Location = new System.Drawing.Point(134, 102);
            this.PatId.Name = "PatId";
            this.PatId.Size = new System.Drawing.Size(241, 22);
            this.PatId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "PatientID";
            // 
            // PatName
            // 
            this.PatName.BackColor = System.Drawing.Color.Gainsboro;
            this.PatName.Location = new System.Drawing.Point(134, 130);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(241, 22);
            this.PatName.TabIndex = 5;
            // 
            // PatAddress
            // 
            this.PatAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.PatAddress.Location = new System.Drawing.Point(134, 158);
            this.PatAddress.Name = "PatAddress";
            this.PatAddress.Size = new System.Drawing.Size(241, 22);
            this.PatAddress.TabIndex = 6;
            // 
            // PatContact
            // 
            this.PatContact.BackColor = System.Drawing.Color.Gainsboro;
            this.PatContact.Location = new System.Drawing.Point(134, 186);
            this.PatContact.Name = "PatContact";
            this.PatContact.Size = new System.Drawing.Size(241, 22);
            this.PatContact.TabIndex = 7;
            // 
            // PatAge
            // 
            this.PatAge.BackColor = System.Drawing.Color.Gainsboro;
            this.PatAge.Location = new System.Drawing.Point(134, 214);
            this.PatAge.Name = "PatAge";
            this.PatAge.Size = new System.Drawing.Size(241, 22);
            this.PatAge.TabIndex = 8;
            // 
            // PatGenderCb
            // 
            this.PatGenderCb.BackColor = System.Drawing.Color.Gainsboro;
            this.PatGenderCb.FormattingEnabled = true;
            this.PatGenderCb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.PatGenderCb.Location = new System.Drawing.Point(134, 244);
            this.PatGenderCb.Name = "PatGenderCb";
            this.PatGenderCb.Size = new System.Drawing.Size(241, 24);
            this.PatGenderCb.TabIndex = 9;
            this.PatGenderCb.Text = "Select Gender";
            // 
            // PatBloodCb
            // 
            this.PatBloodCb.BackColor = System.Drawing.Color.Gainsboro;
            this.PatBloodCb.FormattingEnabled = true;
            this.PatBloodCb.Items.AddRange(new object[] {
            "A(+)",
            "A(-)",
            "B(+)",
            "B(-)",
            "AB(+)",
            "AB(-)",
            "O(+)",
            "O(-)"});
            this.PatBloodCb.Location = new System.Drawing.Point(134, 274);
            this.PatBloodCb.Name = "PatBloodCb";
            this.PatBloodCb.Size = new System.Drawing.Size(241, 24);
            this.PatBloodCb.TabIndex = 10;
            this.PatBloodCb.Text = "Select Blood Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Patient Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Patient Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contact Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Patient Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Blood Group";
            // 
            // PatDisease
            // 
            this.PatDisease.BackColor = System.Drawing.Color.Gainsboro;
            this.PatDisease.Location = new System.Drawing.Point(21, 327);
            this.PatDisease.Name = "PatDisease";
            this.PatDisease.Size = new System.Drawing.Size(354, 22);
            this.PatDisease.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Any Major Disease Suffered Earlier";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(198, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 40);
            this.button4.TabIndex = 22;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Maroon;
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Deletebtn.Location = new System.Drawing.Point(84, 401);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(107, 40);
            this.Deletebtn.TabIndex = 21;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Maroon;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateBtn.Location = new System.Drawing.Point(198, 355);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(107, 40);
            this.UpdateBtn.TabIndex = 20;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(85, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientGV
            // 
            this.PatientGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGV.Location = new System.Drawing.Point(382, 129);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.RowHeadersWidth = 51;
            this.PatientGV.RowTemplate.Height = 24;
            this.PatientGV.Size = new System.Drawing.Size(471, 312);
            this.PatientGV.TabIndex = 23;
            this.PatientGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(490, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 34);
            this.label11.TabIndex = 3;
            this.label11.Text = "PATIENTS LIST";
            // 
            // ExitLbl
            // 
            this.ExitLbl.AutoSize = true;
            this.ExitLbl.BackColor = System.Drawing.Color.Maroon;
            this.ExitLbl.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitLbl.Location = new System.Drawing.Point(834, 0);
            this.ExitLbl.Name = "ExitLbl";
            this.ExitLbl.Size = new System.Drawing.Size(30, 27);
            this.ExitLbl.TabIndex = 4;
            this.ExitLbl.Text = "X";
            this.ExitLbl.Click += new System.EventHandler(this.ExitLbl_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(864, 455);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PatientGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PatDisease);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatBloodCb);
            this.Controls.Add(this.PatGenderCb);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.PatContact);
            this.Controls.Add(this.PatAddress);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PatId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.TextBox PatAddress;
        private System.Windows.Forms.TextBox PatContact;
        private System.Windows.Forms.TextBox PatAge;
        private System.Windows.Forms.ComboBox PatGenderCb;
        private System.Windows.Forms.ComboBox PatBloodCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PatDisease;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView PatientGV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ExitLbl;
    }
}