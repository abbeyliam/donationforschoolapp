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
    public partial class DonationUser : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\5911610043\Programming Final Project\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
        public DonationUser()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            string newCom = "Insert into DonationTable (name,donationtype) values ('" + textBox1.Text + "', '" + this.comboBox1.GetItemText(this.comboBox1.SelectedItem) + "')";
            SqlCommand cmd = new SqlCommand(newCom, sqlCon);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Thanks for your donations");
        }

        
        private void DonationUser_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
