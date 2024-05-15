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
    public partial class UpdatingCustomerDetails : Form
    {
        public UpdatingCustomerDetails()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem; Integrated Security=True ");
            con.Open();
            string query = "UPDATE TB_CUSTOMER SET EMAIL = @EMAIL, PASSWORD = @PASSWORD, DOB = @DOB,FNAME=@FNAME,LNAME=@LNAME,USERNAME=@USERNAME,PASSPORTNUM=@PASSPORTNUM WHERE CUSTOMERID = @CUSTOMERID";
            SqlCommand myCommand2 = new SqlCommand("Update TB_USER_PHONE2(PHONENUM2,USER_NAME2,CUSTOMERID) VALUES('" + textBox9.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox1.Text.ToString() + "')", con);

            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@EMAIL", textBox2.Text);
                command.Parameters.AddWithValue("@PASSWORD", textBox3.Text);
                command.Parameters.AddWithValue("@DOB", textBox4.Text);
                command.Parameters.AddWithValue("@FNAME", textBox5.Text);
                command.Parameters.AddWithValue("@LNAME", textBox6.Text);
                command.Parameters.AddWithValue("@USERNAME", textBox7.Text);
                command.Parameters.AddWithValue("@PASSPORTNUM", textBox8.Text);
                
                command.Parameters.AddWithValue("@CUSTOMERID", textBox1.Text);

                int result = command.ExecuteNonQuery();
                if (result < 0)
                    Console.WriteLine("Error updating data into Database!");
            }
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
