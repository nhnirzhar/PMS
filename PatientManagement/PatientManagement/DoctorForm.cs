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
    public partial class DoctorForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-CKJ30U4F;Initial Catalog=HMS;Integrated Security=True");

        public DoctorForm()
        {
            InitializeComponent();
        }
        void Populate()
        {
            Con.Open();
            string query = "select *from DoctorTb1";
            SqlDataAdapter DA = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(DA);
            var ds = new DataSet();
            DA.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
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
            if (DocId.Text == "" || DocName.Text == "" || DocPass.Text == "" || DocExp.Text == "")
                MessageBox.Show("Something is missing... Enter carefully..");
            else
            {
                Con.Open();
                string query = "insert into DoctorTb1 values(" + DocId.Text + ",'" + DocName.Text + "'," + DocExp.Text + ",'" + DocPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("A Doctor Added Successfully");
                Con.Close();
                Populate();

            }

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "")
                MessageBox.Show("Enter The Doctor Id");
            else
            {
                Con.Open();
                string query = "delete from DoctorTb1 where DocId="+DocId.Text+"";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor has been deleted successfully..");
                Con.Close();
                Populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocId.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            DocExp.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DoctorTb1 set DocName = '" + DocName.Text + "', DocExp = '" + DocExp.Text + "', DocPass='" + DocPass.Text + "' where DocId = " + DocId.Text + "";
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
