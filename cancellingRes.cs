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
    public partial class cancellingRes : Form
    {
        public cancellingRes()
        {
            InitializeComponent();
        }

        private void cancellingRes_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TB_WE_RESERVATION JOIN TB_CUSTOMER ON TB_WE_RESERVATION.CUSTOMERID = TB_CUSTOMER.CUSTOMERID";

            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Open the connection and execute the command
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int resNum = Convert.ToInt32(reader["RESNUM"]);

                        comboBox1.Items.Add(resNum);
                    }
   

                    reader.Close();
                }
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Open the connection and execute the command
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Add the values to the ComboBox
                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["CUSTOMERID"]);

                        comboBox2.Items.Add(ID);

                    }
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem; Integrated Security=True ");
            con.Open();
            int reserveNUM = (int)comboBox1.SelectedItem;
            int Customerid = (int)comboBox2.SelectedItem;
            

            
            SqlCommand myCommand = new SqlCommand("DELETE FROM TB_WE_RESERVATION WHERE RESNUM='" + reserveNUM + "' AND TB_WE_RESERVATION.CUSTOMERID='"+Customerid+"'", con);
            int rowsAffected = myCommand.ExecuteNonQuery();
            if (rowsAffected>0)
            {
                MessageBox.Show("Successfully Deleted");
            }
            else 
            {
                MessageBox.Show("Please choose the correct reservation number");
            }

            myCommand.ExecuteNonQuery();
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
