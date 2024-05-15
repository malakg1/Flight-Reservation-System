﻿using System;
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
    public partial class update_aircraft : Form
    {
        public update_aircraft()
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
            string query = "UPDATE TB_AIRCRAFT SET CAPACITY = @CAPACITY, AIRLINE = @AIRLINE, MODELNUM = @MODELNUM WHERE SERIALNUM = @SERIALNUM";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@AIRLINE", textBox3.Text);
                command.Parameters.AddWithValue("@MODELNUM", textBox4.Text);
                command.Parameters.AddWithValue("@CAPACITY", textBox2.Text);
                command.Parameters.AddWithValue("@SERIALNUM", textBox1.Text);

                int result = command.ExecuteNonQuery();
                if (result < 0)
                    Console.WriteLine("Error updating data into Database!");
            }
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
