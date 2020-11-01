using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace HotelManagementSystemRoom
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }
        string ConString = ConfigurationManager.ConnectionStrings["HotelManagementSystemRoom.Properties.Settings.HotelConnectionString"].ConnectionString;

        public void updateCustomer()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " Update customer set customer_status ='checkOut' where name='" + clientName.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();



            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();

        }
        public void updateRoom()

        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " Update rooms set status='NotActive' where room_no='" + RoomNo.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();



            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();

        }
        public string roomNOs = "";
        public void loadActiveRoomLodger()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {

                string getCust = "select name,indate,outdate,roomno from customer where name= '" + comboBoxRoomSelection.Text + "'";
                MySqlCommand cmd = new MySqlCommand(getCust, con);



                MySqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    clientName.Text = dr.GetString(0);

                   
                    date_in.Text = dr.GetString(1);
                    date_out.Text = dr.GetString(2);
                    RoomNo.Text = dr.GetString(3);
                    roomNOs= dr.GetString(3);
                    //roomCategory.Text = dr.GetString("roomtype");

                    DateTime inputDate = Convert.ToDateTime(dr.GetString(1));
                    DateTime outputDate = Convert.ToDateTime(dr.GetString(2));

                    TimeSpan diff = outputDate - inputDate;
                    Double days = diff.TotalDays;
                    int day = Convert.ToInt32(days);


                    daysSpent.Text = day.ToString();



                }


            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }
        public void loadActiveRoom()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string getCust = "select name from customer where customer_status ='checkIn' and payment_status ='paid'";


                MySqlCommand cmd = new MySqlCommand(getCust, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string filRoom = dr.GetString(0);

                    comboBoxRoomSelection.Items.Add(filRoom);

                }

            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            loadActiveRoomLodger();
            updateCustomer();
            updateRoom();
            MessageBox.Show("Saved");
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            loadActiveRoom();
            date_Time.Text = DateTime.Now.ToString();
        }
        Bitmap bitmap;
        private void button6_Click(object sender, EventArgs e)
        {
            this.Controls.Add(panel1);
            Graphics grp = panel1.CreateGraphics();
            Size formSize = this.ClientSize;
            Size panelSize = panel1.Size;
            bitmap = new Bitmap(556, 437, grp);
            grp = Graphics.FromImage(bitmap);

            Point panelLocation = PointToScreen(panel1.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 8, 12, panelSize);
            printPreviewDialog1.Document = printDocument1;
            // printPreviewDialog1.PrintPreviewControl.Zoom = 1;

            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        private void comboBoxRoomSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRoomSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            loadActiveRoomLodger();
            selectroomProperties();
        }
        public void selectroomProperties()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string roomSelection = "select room_rate,room_type from rooms where room_no= '" + roomNOs + "'";
                MySqlCommand roomSelectioncmd = new MySqlCommand(roomSelection, con);

                MySqlDataReader dr2 = roomSelectioncmd.ExecuteReader();
                if (dr2.Read())
                {
                    roomCost.Text = dr2.GetString("room_rate");
                    // roomCategory.Text = dr2.GetString(1);


                }
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

    }
}
