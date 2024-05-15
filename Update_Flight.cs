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
    public partial class Update_Flight : Form
    {
        public Update_Flight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem;Integrated Security=True";
            int adminIdValue = (int)comboBoxAdmin.SelectedItem;
            int flightIdValue = (int)comboBoxFlightId.SelectedItem;
            string query = "UPDATE TB_FLIGHT SET ARRIVALDATE=@ARRIVALDATE, FLIGHID=@FLIGHID,ADMINID=@ADMINID, ARRIVALTIME=@ARRIVALTIME,ARRIVALLOCATION=@ARRIVALLOCATION,DEPTTIME=@DEPTTIME,DEPTDATE=@DEPTDATE,DEPTLOCATION=@DEPTLOCATION WHERE FLIGHID=@FLIGHID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ARRIVALDATE", textBox2.Text);
                    command.Parameters.AddWithValue("@ARRIVALLOCATION", textBox3.Text);
                    command.Parameters.AddWithValue("@ARRIVALTIME", textBox4.Text);
                    command.Parameters.AddWithValue("@DEPTTIME", textBox5.Text);
                    command.Parameters.AddWithValue("@DEPTDATE", textBox6.Text);
                    command.Parameters.AddWithValue("@DEPTLOCATION", textBox7.Text);
                    command.Parameters.AddWithValue("@ADMINID", adminIdValue);
                    command.Parameters.AddWithValue("@FLIGHID", flightIdValue);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Update_Flight_Load(object sender, EventArgs e)
        
            {
                string connectionString = "Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT FLIGHID FROM TB_FLIGHT", connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                             int id = Convert.ToInt32(reader["FLIGHID"]);

                            comboBoxFlightId.Items.Add(id);
                           //comboBoxFlightId.Items.Add(reader.GetInt32(0));
                        }
                        reader.Close();
                    }
                }
                comboBoxFlightId.SelectedIndex = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT ADMINID FROM TB_ADMIN", connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                             int id = Convert.ToInt32(reader["ADMINID"]);

                              comboBoxAdmin.Items.Add(id);
                       // comboBoxAdmin.Items.Add(reader.GetInt32(0));
                        }
                        reader.Close();
                    }
                }
                comboBoxAdmin.SelectedIndex = 0;
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
