using System;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Drawing;
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
    public partial class NewCustomers : Form
    {
        public NewCustomers()
        {
            InitializeComponent();
        }
        string ConString = ConfigurationManager.ConnectionStrings["HotelManagementSystemRoom.Properties.Settings.HotelConnectionString"].ConnectionString;

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " INSERT INTO customer(name,address,mobile,email,state,indate,outdate,noofper,roomtype,roomno,customer_status) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.Date + "','" + dateTimePicker2.Value.Date + "','" + comboBox3.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','checkIn'); ";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string updateRoomStatus = " Update rooms set status ='Active' where room_no='" + comboBox1.Text + "'";

                MySqlCommand cmdupdateRoomStatus = new MySqlCommand(updateRoomStatus, con);
                cmdupdateRoomStatus.ExecuteNonQuery();

                string str1 = "select max(id) from customer ;";

                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Welcome , " + textBox1.Text + "' in the Hotel Partners.. ");
                 

                }
              
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void NewCustomers_Load(object sender, EventArgs e)
        {
            loadActiveRoom();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadActiveRoom()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string getCust = "select room_no from rooms where status='NotActive'";

                MySqlCommand cmd = new MySqlCommand(getCust, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string fil1 = dr.GetString(0);

                    comboBox1.Items.Add(fil1);
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
