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
    public partial class Restaurant_Home_Page : Form
    {
        public Restaurant_Home_Page()
        {
            InitializeComponent();
        }
        public delegate void delPassData(Label text);
        public void funData(TextBox txtForm1)
        {
            label1.Text = txtForm1.Text;
        }

        private void makeSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Make_Sales frm = new Make_Sales();
            delPassData del = new delPassData(frm.funData);
            del(this.label1);
            frm.ShowDialog();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Sales obj2 = new View_Sales();
            obj2.ShowDialog();
        }

        private void addMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu obj5 = new Menu();
            obj5.ShowDialog();
        }

        private void Restaurant_Home_Page_Load(object sender, EventArgs e)
        {

        }
       
    }
}
