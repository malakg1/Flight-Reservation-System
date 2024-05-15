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
    public partial class adminSignUp : Form
    {
        public adminSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("INSERT INTO TB_ADMIN(ADMINID,ROLE,EMAIL,PASSWORD,FNAME,LNAME,USERNAME) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox8.Text.ToString() + "')", con);
            
            var Adminhm = new Admin_homepage();
            Adminhm.Show();

            myCommand.ExecuteNonQuery();
            con.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
