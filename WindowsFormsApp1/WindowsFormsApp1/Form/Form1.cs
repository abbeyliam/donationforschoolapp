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



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\5911610043\Programming Final Project\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");

        

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sqlCon.Open();
            string newCom = " Select username, password from useradminTable where username= '" + textBox1.Text + "' AND password = '" + textBox2.Text + "' ";
            SqlCommand cmd = new SqlCommand(newCom, sqlCon);
            SqlDataReader myReader;

            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string userName = myReader.GetString(0);

                if (textBox1.Text == "admin")
                {
                    DonationAdmin.getUsername = userName;
                    DonationAdmin donad = new DonationAdmin();
                    donad.Show();
                    this.Hide();
                    
                }
                else
                {
                    DonationUser donus = new DonationUser();
                    donus.Show();
                    this.Hide();
                }



            }

            sqlCon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
