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
using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Drawing;

namespace HotelManagementSystemRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void delPassData(TextBox text);
        public delegate void delPassDatas(string text);

       
        public string retrieveRole;
        private void button1_Click(object sender, EventArgs e)
        {

            string ConString = ConfigurationManager.ConnectionStrings["HotelManagementSystemRoom.Properties.Settings.HotelConnectionString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(ConString);
            //SqlConnection con = new SqlConnection(@"
//Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Oladiti Tajudeen A\Downloads\Compressed\kashipara.com_HotelManagementSystemRoom-zip\HotelManagementSystemRoom\HotelManagementSystemRoom\Hotel.mdf;Integrated Security=True;User Instance=True");
            con.Open();

            string str = "SELECT username,role FROM staff WHERE password='" + textBox2.Text + "' && username='" + textBox1.Text + "'";
            MySqlCommand cmd = new MySqlCommand(str, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr.GetString("role") == "manager")
                {
                    this.Visible = false;
  
                    string roles = "manager";
                    Home frm = new Home();
                    delPassDatas dels = new delPassDatas(frm.funData);
                    dels(roles);
                    frm.ShowDialog();

                }
                else if(dr.GetString("role") == "restaurant")
                {
                    
                    this.Visible = false;
                   
                    Restaurant_Home_Page frm = new Restaurant_Home_Page();
                    delPassData del = new delPassData(frm.funData);
                    del(this.textBox1);
                    frm.ShowDialog();


                }
                else
                {
                    this.Visible = false;
                 
                    Reception_Home_Page obj4 = new Reception_Home_Page();
                    delPassData del = new delPassData(obj4.funData);
                    del(this.textBox1);
                    obj4.ShowDialog();

                }

            }
            else
            {
                MessageBox.Show("Invalid username and Password.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
