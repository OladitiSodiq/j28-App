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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }
        string ConString = ConfigurationManager.ConnectionStrings["HotelManagementSystemRoom.Properties.Settings.HotelConnectionString"].ConnectionString;

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " Update customer set outdate ='" + dateTimePickerOutDate.Value.Date + "' where id='" + textBox1.Text + "'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from customer ;";

                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Customer, "+textBox1.Text+"'s Infromation is updated successfully");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            textBox11.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            MySqlConnection con = new MySqlConnection(ConString);

            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select name,address,mobile,email,state,indate,outdate,noofper,roomtype,roomno from customer where id=" + Convert.ToInt32(textBox1.Text) + " ;";

                    MySqlCommand cmd = new MySqlCommand(getCust, con);
                    MySqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox11.Text = dr.GetValue(0).ToString();
                        textBox2.Text = dr.GetValue(1).ToString();
                        textBox3.Text = dr.GetValue(2).ToString();
                        textBox4.Text = dr.GetValue(3).ToString();
                        textBox5.Text = dr.GetValue(4).ToString();
                        textBox6.Text = dr.GetValue(5).ToString();
                        textBox7.Text = dr.GetValue(6).ToString();
                        textBox8.Text = dr.GetValue(7).ToString();
                        textBox9.Text = dr.GetValue(8).ToString();
                        textBox10.Text = dr.GetValue(9).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Sorry '" + textBox1.Text + "' This Customer Id is not Available, Please Check Id..");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";
                        textBox10.Text = "";
                    }
                }
                catch (MySqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
