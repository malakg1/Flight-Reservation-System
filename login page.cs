using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight
{
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem; Integrated Security=True ");
            con.Open();
            int customerId;
            if (int.TryParse(textBox1.Text, out customerId))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TB_CUSTOMER where CUSTOMERID=" + customerId + " and PASSWORD='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    var customerLogin = new Customer_homepage();
                    customerLogin.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please enter the right information");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid customer ID");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem; Integrated Security=True ");
            con.Open();
            int adminId;
            if (int.TryParse(textBox1.Text, out adminId))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM TB_ADMIN WHERE ADMINID=" + adminId + " AND PASSWORD='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    var AdminLogin = new Admin_homepage();
                    AdminLogin.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please enter the right information");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid admin ID");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var SignupPage = new signUpCUSTOMER();
            SignupPage.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
