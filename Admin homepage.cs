using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight
{
    public partial class Admin_homepage : Form
    {
        public Admin_homepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AddCraft = new add_Aircraft();
            AddCraft.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Addflight = new add_flight();
            Addflight.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var updateAircraft = new update_aircraft();
            updateAircraft.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var cancelAirCraft = new cancel_aircraft();
            cancelAirCraft.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var updateFlight = new Update_Flight();
            updateFlight.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
