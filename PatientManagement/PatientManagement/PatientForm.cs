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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-CKJ30U4F;Initial Catalog=HMS;Integrated Security=True");
        void Populate()
        {
            Con.Open();
            string query = "select *from PatientTb1";
            SqlDataAdapter DA = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(DA);
            var ds = new DataSet();
            DA.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PatAddress.Text == "" || PatContact.Text == "" || PatAge.Text=="" || PatGenderCb.SelectedItem.ToString() =="" || PatDisease.Text == "")
                MessageBox.Show("Something is missing... Enter carefully..");
            else
            {
                Con.Open();
                string query = "insert into PatientTb1 values(" + PatId.Text + ",'" + PatName.Text + "','" + PatAddress.Text + "','" + PatContact.Text + "',"+PatAge.Text+",'"+PatGenderCb.SelectedItem.ToString()+"','"+PatBloodCb.SelectedItem.ToString()+"','"+PatDisease.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("A Patient Added Successfully");
                Con.Close();
                Populate();

            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
                MessageBox.Show("Enter The Patient Id");
            else
            {
                Con.Open();
                string query = "delete from PatientTb1 where PatientId=" + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient has been deleted successfully..");
                Con.Close();
                Populate();
            }
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAddress.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatContact.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            PatDisease.Text = PatientGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update PatientTb1 set PatName = '" + PatName.Text + "', PatAddress = '" + PatAddress.Text + "', PatContact='" + PatContact.Text + "', PatAge="+PatAge.Text+ ", PatGender= '" + PatGenderCb.SelectedItem.ToString() + "', PatBlood = '" + PatBloodCb.SelectedItem.ToString() + "', PatDisease = '" + PatDisease.Text + "' where PatientId = " + PatId.Text + "";
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
