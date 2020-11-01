using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManagementSystemRoom
{
    public partial class Reception_Home_Page : Form
    {
        public Reception_Home_Page()
        {
            InitializeComponent();
        }
        public delegate void delPassData(Label text);
        public void funData(TextBox txtForm1)
        {
            label1.Text = txtForm1.Text;
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            Bill frm = new Bill();
            delPassData del = new delPassData(frm.funData);
            del(this.label1);
            frm.ShowDialog();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewCustomers obj3 = new NewCustomers();
            obj3.ShowDialog();
        }
        private void customersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CustomersInfo obj5 = new CustomersInfo();
            obj5.ShowDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newCustomerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomer obj4 = new UpdateCustomer();
            obj4.ShowDialog();
        }

        private void newRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomsInfo obj1 = new RoomsInfo();
            obj1.ShowDialog();
        }

        private void Reception_Home_Page_Load(object sender, EventArgs e)
        {

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkout obj7 = new Checkout();
            obj7.ShowDialog();
        }
    }
}
