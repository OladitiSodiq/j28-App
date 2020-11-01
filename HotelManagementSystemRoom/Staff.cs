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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        string ConString = ConfigurationManager.ConnectionStrings["HotelManagementSystemRoom.Properties.Settings.HotelConnectionString"].ConnectionString;

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void addStaffbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " INSERT INTO staff(fullname,username,password,role) VALUES('" + textBox1.Text + "','" + textBoxUsername.Text + "','" + textBoxConfirmPassword.Text + "','" + comboBoxStaff_Role.Text +  "'); ";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from staff ;";

                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show(  textBoxUsername.Text + "'Welcome To J2B Hotel ");
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

        private void button1_Click(object sender, EventArgs e)
        {
           using (MySqlConnection con = new MySqlConnection(ConString))
            {

                string str = "SELECT * FROM staff";
                MySqlCommand cmd = new MySqlCommand(str, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
