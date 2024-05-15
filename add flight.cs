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
    public partial class add_flight : Form
    {
        public add_flight()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TB_FLIGHT (FLIGHID, ADMINID,ARRIVALDATE,ARRIVALLOCATION,ARRIVALTIME,DEPTTIME,DEPTDATE,DEPTLOCATION) VALUES (@FLIGHID,@ADMINID,@ARRIVALDATE,@ARRIVALLOCATION,@ARRIVALTIME,@DEPTTIME,@DEPTDATE,@DEPTLOCATION)";

            // Get the selected value from the ComboBox
            int ForeignKeyValue = (int)comboBox1.SelectedItem;


            // Set up the connection and command objects
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter values to the command object
                    command.Parameters.AddWithValue("@FLIGHID", textBox1.Text);
                    command.Parameters.AddWithValue("@ARRIVALDATE", textBox3.Text);
                    command.Parameters.AddWithValue("@ARRIVALLOCATION", textBox4.Text);
                    command.Parameters.AddWithValue("@ARRIVALTIME", textBox5.Text);
                    command.Parameters.AddWithValue("@DEPTTIME", textBox6.Text);
                    command.Parameters.AddWithValue("@DEPTDATE", textBox7.Text);
                    command.Parameters.AddWithValue("@DEPTLOCATION", textBox8.Text);
                    command.Parameters.AddWithValue("@ADMINID", ForeignKeyValue);

                    // Open the connection and execute the command
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Flight Added Succesfully");
                }
            }

        }



        private void add_flight_Load(object sender, EventArgs e)
        {

            // Set up the SQL query to select the values for the ComboBox
            string query = "SELECT ADMINID FROM TB_ADMIN";

            // Set up the connection and command objects
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
                        int id = Convert.ToInt32(reader["ADMINID"]);

                        comboBox1.Items.Add(id);
                    }

                    reader.Close();
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {


        }

        private string GetDetails(string selectedValue)

        {
            // Query the database or perform some other action to get the details for the selected item
            // and return the details as a string
            return "Details for " + selectedValue;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
