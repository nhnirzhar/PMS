using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PatientManagement
{
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-CKJ30U4F;Initial Catalog=HMS;Integrated Security=True");
        void Populate()
        {
            Con.Open();
            string query = "select *from DiagnosisTb1";
            SqlDataAdapter DA = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(DA);
            var ds = new DataSet();
            DA.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        void PopulateCombo()
        {
            string Sql = "select * from PatientTb1";
            SqlCommand cmd = new SqlCommand(Sql, Con);
            SqlDataReader rdr;

            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatientId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember = "PatientId";
                PatientIdCb.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        string patientName;
        void DisplayedPatientName()
        {
            Con.Open();
            string mysql = "select *from PatientTb1 where PatientId = "+PatientIdCb.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                patientName = dr["PatName"].ToString();
                PatName.Text = patientName;
            }
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DiaId.Text == "" || Symptoms.Text == "" || Diagnosis.Text == "" || Medicines.Text == "" ||  PatName.Text == "")
                MessageBox.Show("Something is missing... Enter carefully..");
            else
            {
                Con.Open();
                string query = "insert into DiagnosisTb1 values(" + DiaId.Text + "," + PatientIdCb.SelectedValue.ToString() + ",'" + PatName.Text + "','" + Symptoms.Text + "','" + Diagnosis.Text + "','" + Medicines.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Added Successfully");
                Con.Close();
                Populate();

            }
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            
            PopulateCombo();
            Populate();
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DisplayedPatientName();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (DiaId.Text == "")
                MessageBox.Show("Enter The Diagnosis Id");
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTb1 where DiaId=" + DiaId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Data has been deleted successfully..");
                Con.Close();
                Populate();
            }
        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiaId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatName.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Symptoms.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Diagnosis.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Medicines.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();

            PateintNameLbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            DiagnosisLbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            SymptomsLbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            MedicinesLbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DiagnosisTb1 set PatientId = " + PatientIdCb.SelectedValue.ToString() + ", PatName = '" + PatName.Text + "', Symptoms='" + Symptoms.Text + "', Diagnosis='" + Diagnosis.Text + "',Medicines='" + Medicines.Text + "' where DiaId = " + DiaId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully...");
            Con.Close();
            Populate();
        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
