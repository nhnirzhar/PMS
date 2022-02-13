﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoctorPb_Click(object sender, EventArgs e)
        {
            DoctorForm Doc = new DoctorForm();
            Doc.Show();
            this.Hide();
        }

        private void PatientPb_Click(object sender, EventArgs e)
        {
            PatientForm Pat = new PatientForm();
            Pat.Show();
            this.Hide();
        }

        private void DiagnosisPb_Click(object sender, EventArgs e)
        {
            DiagnosisForm Diag = new DiagnosisForm();
            Diag.Show();
            this.Hide();
        }
    }
}
