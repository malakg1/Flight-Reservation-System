using flight.bin;
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
    public partial class bookingticket : Form
    {
        private string connectionString = "Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem;Integrated Security=True";

        public bookingticket()
        {
            InitializeComponent();
           
        }

        private void bookingticket_Load(object sender, EventArgs e)
        {
            // Populate the cboFlightId combo box with flight IDs from the Flight table
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem;Integrated Security=True"))
            {
                connection.Open();

                string query = "SELECT FLIGHID FROM TB_FLIGHT";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(Convert.ToInt32(reader.GetValue(0)));
                        }
                    }
                }
            }

            // Populate the cboCustomerId combo box with customer IDs from the Customer table
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem;Integrated Security=True"))
            {
                connection.Open();

                string query = "SELECT CUSTOMERID FROM TB_CUSTOMER";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox2.Items.Add(Convert.ToInt32(reader.GetValue(0)));
                        }
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int selectedFlightId = Convert.ToInt32(comboBox1.SelectedItem);
                int selectedCustomerId = Convert.ToInt32(comboBox2.SelectedItem);
                string query = "INSERT INTO TB_WE_RESERVATION (RESNUM, FLIGHID, CUSTOMERID) VALUES ((SELECT MAX(RESNUM) + 1 FROM TB_WE_RESERVATION), @FLIGHID, @CUSTOMERID)";

                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem;Integrated Security=True"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@FLIGHID", SqlDbType.Int)).Value = selectedFlightId;
                        command.Parameters.Add(new SqlParameter("@CUSTOMERID", SqlDbType.Int)).Value = selectedCustomerId;
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            MessageBox.Show("Reservation created successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to create reservation.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
    
    }

