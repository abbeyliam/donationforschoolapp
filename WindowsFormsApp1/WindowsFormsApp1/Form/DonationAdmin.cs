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
    public partial class DonationAdmin : Form

    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\5911610043\Programming Final Project\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
        public static string getUsername = "";

        public DonationAdmin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard.getUsername1 = getUsername;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DonationAdmin_Load(object sender, EventArgs e)
        {
            sqlCon.Open();
           
           

            SqlDataAdapter sda = new SqlDataAdapter("Select name,donationtype from DonationTable", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                
            }

            sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard.getUsername1 = getUsername;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    } 
}
