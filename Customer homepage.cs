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
    public partial class Customer_homepage : Form
    {
        public Customer_homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Booking = new bookingticket();
            Booking.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Cancelling = new cancellingRes();
            Cancelling.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var UpdatingCustomer = new UpdatingCustomerDetails();
            UpdatingCustomer.Show();
        }

        private void tB_FLIGHTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tB_FLIGHTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flightReservationSystemDataSet);

        }

        private void Customer_homepage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationSystemDataSet.TB_FLIGHT' table. You can move, or remove it, as needed.
            this.tB_FLIGHTTableAdapter.Fill(this.flightReservationSystemDataSet.TB_FLIGHT);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
