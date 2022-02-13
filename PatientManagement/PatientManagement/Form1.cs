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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-CKJ30U4F;Initial Catalog=HMS;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNametxt.Text == "" || Passwordtxt.Text == "")
                MessageBox.Show("Enter valid username and password.");
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from DoctorTb1 where DocName='"+UserNametxt.Text+"' and DocPass = '"+Passwordtxt.Text+"'" , Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString() == "1")
                {
                    Home H = new Home();
                    H.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong UserName or Password");
                }

                Con.Close();

            }

        }

        private void ExitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
