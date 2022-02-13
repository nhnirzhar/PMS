
namespace PatientManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorPb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PatientPb = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DiagnosisPb = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // DoctorPb
            // 
            this.DoctorPb.BackColor = System.Drawing.Color.Transparent;
            this.DoctorPb.Image = ((System.Drawing.Image)(resources.GetObject("DoctorPb.Image")));
            this.DoctorPb.Location = new System.Drawing.Point(239, 115);
            this.DoctorPb.Name = "DoctorPb";
            this.DoctorPb.Size = new System.Drawing.Size(100, 109);
            this.DoctorPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoctorPb.TabIndex = 1;
            this.DoctorPb.TabStop = false;
            this.DoctorPb.Click += new System.EventHandler(this.DoctorPb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(247, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOCTOR";
            // 
            // PatientPb
            // 
            this.PatientPb.BackColor = System.Drawing.Color.Transparent;
            this.PatientPb.Image = ((System.Drawing.Image)(resources.GetObject("PatientPb.Image")));
            this.PatientPb.Location = new System.Drawing.Point(680, 115);
            this.PatientPb.Name = "PatientPb";
            this.PatientPb.Size = new System.Drawing.Size(100, 109);
            this.PatientPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PatientPb.TabIndex = 3;
            this.PatientPb.TabStop = false;
            this.PatientPb.Click += new System.EventHandler(this.PatientPb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(690, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "PATIENT";
            // 
            // DiagnosisPb
            // 
            this.DiagnosisPb.BackColor = System.Drawing.Color.Transparent;
            this.DiagnosisPb.Image = ((System.Drawing.Image)(resources.GetObject("DiagnosisPb.Image")));
            this.DiagnosisPb.Location = new System.Drawing.Point(460, 325);
            this.DiagnosisPb.Name = "DiagnosisPb";
            this.DiagnosisPb.Size = new System.Drawing.Size(100, 98);
            this.DiagnosisPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiagnosisPb.TabIndex = 5;
            this.DiagnosisPb.TabStop = false;
            this.DiagnosisPb.Click += new System.EventHandler(this.DiagnosisPb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(465, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "DIAGNOSIS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(713, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitLbl
            // 
            this.ExitLbl.AutoSize = true;
            this.ExitLbl.BackColor = System.Drawing.Color.Transparent;
            this.ExitLbl.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitLbl.Location = new System.Drawing.Point(805, 0);
            this.ExitLbl.Name = "ExitLbl";
            this.ExitLbl.Size = new System.Drawing.Size(30, 27);
            this.ExitLbl.TabIndex = 8;
            this.ExitLbl.Text = "X";
            this.ExitLbl.Click += new System.EventHandler(this.ExitLbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiagnosisPb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PatientPb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoctorPb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox DoctorPb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PatientPb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox DiagnosisPb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ExitLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}