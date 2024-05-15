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
    public partial class signUpCUSTOMER : Form
    {
        public signUpCUSTOMER()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem; Integrated Security=True ");
    con.Open();

    SqlCommand myCommand = new SqlCommand("INSERT INTO TB_CUSTOMER(CUSTOMERID,EMAIL,PASSWORD,FNAME,LNAME,USERNAME,PASSPORTNUM) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() +"','" + textBox5.Text.ToString() +"','" + textBox6.Text.ToString() +"','" + textBox7.Text.ToString() +"','" + textBox8.Text.ToString() + "')", con);
    SqlCommand myCommand2 = new SqlCommand("INSERT INTO TB_USER_PHONE2(PHONENUM2,USER_NAME2,CUSTOMERID) VALUES('" + textBox9.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox1.Text.ToString() + "')", con);
            var Customerhm = new Customer_homepage();
            Customerhm.Show();

            myCommand.ExecuteNonQuery();
    con.Close();
}

        private void button2_Click(object sender, EventArgs e)
        {
            var AdminPage = new adminSignUp();
            AdminPage.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
