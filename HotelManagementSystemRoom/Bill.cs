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
    public partial class Bill : Form
    {
        private int tot, room, service;
        
        public static string retrieveAttendant ="";
       
        public Bill()
        {
            InitializeComponent();
        }
        public void funData(Label txtForm1)
        {
            receptionist.Text = txtForm1.Text;
        }
        string ConString = ConfigurationManager.ConnectionStrings["HotelManagementSystemRoom.Properties.Settings.HotelConnectionString"].ConnectionString;

        public string retriveSubtotal ="";
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

         
            
        }
        
        private void Bill_Load(object sender, EventArgs e)
        {
            loadActiveRoom();
            date_Time.Text = DateTime.Now.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // food_recipt(DateTime, Attendant_name, item_bought, subTotal, RoomNo, RoomSC, CashierSC, Total, Method_of_payment, name_of_client)

            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string checkMethod_of_payment = "select sum(subTotal) from food_recipt where RoomNo= '" + comboBoxRoomSelection.Text + "' and Method_of_payment ='Treat With Room'";
                MySqlCommand checkMethod_of_paymentcmd = new MySqlCommand(checkMethod_of_payment, con);
                MySqlDataReader dr3 = checkMethod_of_paymentcmd.ExecuteReader();
                while (dr3.Read())
                {
                    MySqlConnection conn = new MySqlConnection(ConString);
                    conn.Open();
                    string checkMethod_of_payments = "select subTotal from food_recipt where RoomNo= '" + comboBoxRoomSelection.Text + "' and Method_of_payment ='Treat With Room'";
                    MySqlCommand checkMethod_of_paymentcmds = new MySqlCommand(checkMethod_of_payments, conn);
                    MySqlDataReader dr4 = checkMethod_of_paymentcmds.ExecuteReader();
                  
                    if (dr4.Read())
                    {
                        //retriveSubtotal = (dr4.IsDBNull(0)) ? "0" : dr4.GetString(0);
                       retriveSubtotal = dr4.GetString(0);
                    }
                    else
                    {
                        retriveSubtotal = "0";
                    }

                    //string service ;
                    otherService.Text = (dr3.IsDBNull(0)) ? retriveSubtotal : dr3.GetString(0);
                   

                   

                }
                
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void comboBoxRoomSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxRoomSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            loadActiveRoomLodger();
            selectroomProperties();
            RoomNo.Text = comboBoxRoomSelection.SelectedItem.ToString();
        }
        public void selectroomProperties()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string roomSelection = "select room_rate,room_type from rooms where room_no= '" + comboBoxRoomSelection.Text + "'";
                MySqlCommand roomSelectioncmd = new MySqlCommand(roomSelection, con);

                MySqlDataReader dr2 = roomSelectioncmd.ExecuteReader();
                if (dr2.Read())
                {
                    roomCost.Text = dr2.GetString(0);
                    roomCategory.Text = dr2.GetString(1);


                }
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            RoomNo.Text = comboBoxRoomSelection.SelectedItem.ToString();
            RoomNo.Visible = true;
            comboBoxRoomSelection.Visible = false;
            RoomSC.Text = textBoxRoomService.Text;
            RoomSC.Visible = true;
            textBoxRoomService.Visible = false;
            CashierSC.Text = textBoxCashierService.Text;
            CashierSC.Visible = true;
            textBoxCashierService.Visible = false;

           // receptionist.Text = retrieveAttendant;

            int subTotal = int.Parse(roomCost.Text) * int.Parse(daysSpent.Text);
            subTotalLlabel.Text = subTotal.ToString();
           

            int OverallTotal;
            OverallTotal = int.Parse(textBoxRoomService.Text) + int.Parse(textBoxCashierService.Text) + int.Parse(subTotalLlabel.Text) + int.Parse(otherService.Text);
            OverallTotalLabel.Text = OverallTotal.ToString();
        }
        Bitmap bitmap;
        private void button6_Click(object sender, EventArgs e)
        {
            this.Controls.Add(panel2);
            Graphics grp = panel2.CreateGraphics();
            Size formSize = this.ClientSize;
            Size panelSize = panel2.Size;
            bitmap = new Bitmap(556, 437, grp);
            grp = Graphics.FromImage(bitmap);
            
            Point panelLocation = PointToScreen(panel2.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 8, 12, panelSize);
            printPreviewDialog1.Document = printDocument1;
           // printPreviewDialog1.PrintPreviewControl.Zoom = 1;

            printPreviewDialog1.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            savebill();
            updateCustomer();
            foodServicesPaid();
            MessageBox.Show("Done");
        }
        public void updateCustomer()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " Update customer set payment_status ='paid' where name='" + clientName.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();



            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();

        }
        public void savebill()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " INSERT INTO bill(roomno,name,indate,outdae,bill_date,bill_attendant,roombill,otherservice,total) VALUES('" + RoomNo.Text + "','" + clientName.Text + "','" + date_in.Text + "','" + date_out.Text + "','" + date_Time.Text + "','" + receptionist.Text + "','" + subTotalLlabel.Text + "','" + otherService.Text + "','" + OverallTotalLabel.Text + "'); ";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from bill;";

                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Bill is Created.. ");
                    this.Hide();

                }
                this.Close();
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }


        public void foodServicesPaid()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " Update food_recipt set Method_of_payment ='Paid' where RoomNo='" + RoomNo.Text + "' && name_of_client='"+clientName.Text+"'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();



            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
            

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
            Bitmap bmp = new Bitmap(panel2.Width, panel2.Height, panel2.CreateGraphics());
            panel2.DrawToBitmap(bmp, new Rectangle(0, 0, panel2.Width, panel2.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        public void loadActiveRoomLodger()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                
                string getCust = "select name,indate,outdate from customer where roomno= '" + comboBoxRoomSelection.Text + "' and customer_status ='checkIn'";
                MySqlCommand cmd = new MySqlCommand(getCust, con);

                   

                MySqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    
                    clientName.Text = dr.GetString(0);
                    date_in.Text = dr. GetString(1);
                    date_out.Text = dr.GetString(2);
                    RoomNo.Text = comboBoxRoomSelection.Text;

                  
                     DateTime inputDate = Convert.ToDateTime(dr.GetString("indate"));
                     DateTime outputDate = Convert.ToDateTime(dr.GetString("outdate"));

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
                string getCust = "select room_no from rooms where status='Active'";

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
       
    }
}
