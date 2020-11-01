using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;


namespace HotelManagementSystemRoom
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public delegate void delPassDatas(Label text);
        public void funData(String txtForm1)
        {
            label1.Text = txtForm1;
        }

        private void Home2_Load(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Make_Sales frm = new Make_Sales();
            delPassDatas del = new delPassDatas(frm.funData);
            del(this.label1);
            frm.ShowDialog();
        }

        private void viewHotelBillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_Bill obj1 = new View_Bill();
            obj1.ShowDialog();
        }

        private void viewHotelBillToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomsInfo obj2 = new RoomsInfo();
            obj2.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CustomersInfo obj3 = new CustomersInfo();
            obj3.ShowDialog();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NewCustomers obj4 = new NewCustomers();
            obj4.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdateCustomer obj5 = new UpdateCustomer();
            obj5.ShowDialog();
        }
    }
}
