using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace HotelManagementSystemRoom
{
    public partial class View_Sales : Form
    {
        public View_Sales()
        {
            InitializeComponent();
        }
        string ConString = ConfigurationManager.ConnectionStrings["HotelManagementSystemRoom.Properties.Settings.HotelConnectionString"].ConnectionString;

        private void View_Sales_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(ConString))
            {

                string str = "SELECT * FROM food_recipt";
                MySqlCommand cmd = new MySqlCommand(str, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
