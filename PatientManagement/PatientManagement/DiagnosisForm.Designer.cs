
namespace PatientManagement
{
    partial class DiagnosisForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PatientIdCb = new System.Windows.Forms.ComboBox();
            this.Diagnosis = new System.Windows.Forms.TextBox();
            this.Symptoms = new System.Windows.Forms.TextBox();
            this.PatName = new System.Windows.Forms.TextBox();
            this.Medicines = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DiaId = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.DiagnosisGV = new System.Windows.Forms.DataGridView();
            this.DiagnosisSummaryP = new System.Windows.Forms.Panel();
            this.MedicinesLbl = new System.Windows.Forms.Label();
            this.DiagnosisLbl = new System.Windows.Forms.Label();
            this.SymptomsLbl = new System.Windows.Forms.Label();
            this.DiagSummary = new System.Windows.Forms.Label();
            this.PateintNameLbl = new System.Windows.Forms.Label();
            this.ExitLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
            this.DiagnosisSummaryP.SuspendLayout();
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
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(333, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "DIAGNOSIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "PatientID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Diagnosis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Symptoms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Medicines";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Patient Name";
            // 
            // PatientIdCb
            // 
            this.PatientIdCb.BackColor = System.Drawing.Color.Gainsboro;
            this.PatientIdCb.FormattingEnabled = true;
            this.PatientIdCb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.PatientIdCb.Location = new System.Drawing.Point(128, 131);
            this.PatientIdCb.Name = "PatientIdCb";
            this.PatientIdCb.Size = new System.Drawing.Size(241, 24);
            this.PatientIdCb.TabIndex = 22;
            this.PatientIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCb_SelectionChangeCommitted);
            // 
            // Diagnosis
            // 
            this.Diagnosis.BackColor = System.Drawing.Color.Gainsboro;
            this.Diagnosis.Location = new System.Drawing.Point(128, 215);
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.Size = new System.Drawing.Size(241, 22);
            this.Diagnosis.TabIndex = 21;
            // 
            // Symptoms
            // 
            this.Symptoms.BackColor = System.Drawing.Color.Gainsboro;
            this.Symptoms.Location = new System.Drawing.Point(128, 187);
            this.Symptoms.Name = "Symptoms";
            this.Symptoms.Size = new System.Drawing.Size(241, 22);
            this.Symptoms.TabIndex = 20;
            // 
            // PatName
            // 
            this.PatName.BackColor = System.Drawing.Color.Gainsboro;
            this.PatName.Enabled = false;
            this.PatName.Location = new System.Drawing.Point(128, 159);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(241, 22);
            this.PatName.TabIndex = 19;
            // 
            // Medicines
            // 
            this.Medicines.BackColor = System.Drawing.Color.Gainsboro;
            this.Medicines.Location = new System.Drawing.Point(128, 243);
            this.Medicines.Name = "Medicines";
            this.Medicines.Size = new System.Drawing.Size(241, 22);
            this.Medicines.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "DiagnosisID";
            // 
            // DiaId
            // 
            this.DiaId.BackColor = System.Drawing.Color.Gainsboro;
            this.DiaId.Location = new System.Drawing.Point(128, 103);
            this.DiaId.Name = "DiaId";
            this.DiaId.Size = new System.Drawing.Size(241, 22);
            this.DiaId.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(262, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 40);
            this.button4.TabIndex = 31;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Maroon;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.Location = new System.Drawing.Point(148, 317);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(107, 40);
            this.DeleteBtn.TabIndex = 30;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Maroon;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateBtn.Location = new System.Drawing.Point(262, 271);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(107, 40);
            this.UpdateBtn.TabIndex = 29;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Maroon;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddBtn.Location = new System.Drawing.Point(149, 271);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(107, 40);
            this.AddBtn.TabIndex = 28;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(320, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 34);
            this.label11.TabIndex = 32;
            this.label11.Text = "DIAGNOSIS LIST";
            // 
            // DiagnosisGV
            // 
            this.DiagnosisGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiagnosisGV.Location = new System.Drawing.Point(12, 405);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.RowHeadersWidth = 51;
            this.DiagnosisGV.RowTemplate.Height = 24;
            this.DiagnosisGV.Size = new System.Drawing.Size(828, 184);
            this.DiagnosisGV.TabIndex = 33;
            this.DiagnosisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGV_CellContentClick);
            // 
            // DiagnosisSummaryP
            // 
            this.DiagnosisSummaryP.Controls.Add(this.MedicinesLbl);
            this.DiagnosisSummaryP.Controls.Add(this.DiagnosisLbl);
            this.DiagnosisSummaryP.Controls.Add(this.SymptomsLbl);
            this.DiagnosisSummaryP.Controls.Add(this.DiagSummary);
            this.DiagnosisSummaryP.Controls.Add(this.PateintNameLbl);
            this.DiagnosisSummaryP.Location = new System.Drawing.Point(387, 103);
            this.DiagnosisSummaryP.Name = "DiagnosisSummaryP";
            this.DiagnosisSummaryP.Size = new System.Drawing.Size(453, 242);
            this.DiagnosisSummaryP.TabIndex = 34;
            // 
            // MedicinesLbl
            // 
            this.MedicinesLbl.AutoSize = true;
            this.MedicinesLbl.BackColor = System.Drawing.Color.DarkGray;
            this.MedicinesLbl.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicinesLbl.ForeColor = System.Drawing.Color.Black;
            this.MedicinesLbl.Location = new System.Drawing.Point(299, 159);
            this.MedicinesLbl.Name = "MedicinesLbl";
            this.MedicinesLbl.Size = new System.Drawing.Size(100, 23);
            this.MedicinesLbl.TabIndex = 9;
            this.MedicinesLbl.Text = "Medicines";
            // 
            // DiagnosisLbl
            // 
            this.DiagnosisLbl.AutoSize = true;
            this.DiagnosisLbl.BackColor = System.Drawing.Color.DarkGray;
            this.DiagnosisLbl.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosisLbl.ForeColor = System.Drawing.Color.Black;
            this.DiagnosisLbl.Location = new System.Drawing.Point(299, 82);
            this.DiagnosisLbl.Name = "DiagnosisLbl";
            this.DiagnosisLbl.Size = new System.Drawing.Size(95, 23);
            this.DiagnosisLbl.TabIndex = 8;
            this.DiagnosisLbl.Text = "Diagnosis";
            // 
            // SymptomsLbl
            // 
            this.SymptomsLbl.AutoSize = true;
            this.SymptomsLbl.BackColor = System.Drawing.Color.DarkGray;
            this.SymptomsLbl.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymptomsLbl.ForeColor = System.Drawing.Color.Black;
            this.SymptomsLbl.Location = new System.Drawing.Point(35, 159);
            this.SymptomsLbl.Name = "SymptomsLbl";
            this.SymptomsLbl.Size = new System.Drawing.Size(100, 23);
            this.SymptomsLbl.TabIndex = 7;
            this.SymptomsLbl.Text = "Symptoms";
            // 
            // DiagSummary
            // 
            this.DiagSummary.AutoSize = true;
            this.DiagSummary.BackColor = System.Drawing.Color.DarkGray;
            this.DiagSummary.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagSummary.ForeColor = System.Drawing.Color.Firebrick;
            this.DiagSummary.Location = new System.Drawing.Point(73, 5);
            this.DiagSummary.Name = "DiagSummary";
            this.DiagSummary.Size = new System.Drawing.Size(289, 27);
            this.DiagSummary.TabIndex = 6;
            this.DiagSummary.Text = "DIAGNOSIS SUMMARY";
            // 
            // PateintNameLbl
            // 
            this.PateintNameLbl.AutoSize = true;
            this.PateintNameLbl.BackColor = System.Drawing.Color.DarkGray;
            this.PateintNameLbl.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PateintNameLbl.ForeColor = System.Drawing.Color.Black;
            this.PateintNameLbl.Location = new System.Drawing.Point(35, 82);
            this.PateintNameLbl.Name = "PateintNameLbl";
            this.PateintNameLbl.Size = new System.Drawing.Size(131, 23);
            this.PateintNameLbl.TabIndex = 4;
            this.PateintNameLbl.Text = "Patient Name";
            // 
            // ExitLbl
            // 
            this.ExitLbl.AutoSize = true;
            this.ExitLbl.BackColor = System.Drawing.Color.Maroon;
            this.ExitLbl.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitLbl.Location = new System.Drawing.Point(831, 0);
            this.ExitLbl.Name = "ExitLbl";
            this.ExitLbl.Size = new System.Drawing.Size(30, 27);
            this.ExitLbl.TabIndex = 3;
            this.ExitLbl.Text = "X";
            this.ExitLbl.Click += new System.EventHandler(this.ExitLbl_Click);
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(864, 601);
            this.Controls.Add(this.DiagnosisSummaryP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatientIdCb);
            this.Controls.Add(this.Diagnosis);
            this.Controls.Add(this.Symptoms);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.Medicines);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiaId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            this.DiagnosisSummaryP.ResumeLayout(false);
            this.DiagnosisSummaryP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PatientIdCb;
        private System.Windows.Forms.TextBox Diagnosis;
        private System.Windows.Forms.TextBox Symptoms;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.TextBox Medicines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DiaId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DiagnosisGV;
        private System.Windows.Forms.Panel DiagnosisSummaryP;
        private System.Windows.Forms.Label PateintNameLbl;
        private System.Windows.Forms.Label MedicinesLbl;
        private System.Windows.Forms.Label DiagnosisLbl;
        private System.Windows.Forms.Label SymptomsLbl;
        private System.Windows.Forms.Label DiagSummary;
        private System.Windows.Forms.Label ExitLbl;
    }
}