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
    public partial class add_Aircraft : Form
    {
        public add_Aircraft()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K4BFQ39K;Initial Catalog=FlightReservationSystem; Integrated Security=True ");
            con.Open();

            SqlCommand myCommand = new SqlCommand("insert into TB_AIRCRAFT (SERIALNUM,CAPACITY,AIRLINE,MODELNUM) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')", con);
            MessageBox.Show("Aircraft Added Successfully");
            myCommand.ExecuteNonQuery();
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
