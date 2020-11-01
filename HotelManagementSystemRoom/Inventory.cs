using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Drawing;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace HotelManagementSystemRoom
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        string ConString = ConfigurationManager.ConnectionStrings["HotelManagementSystemRoom.Properties.Settings.HotelConnectionString"].ConnectionString;


        private void Inventory_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(ConString))
            {

                string str = "SELECT * FROM hotel_inventory";
                MySqlCommand cmd = new MySqlCommand(str, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
           public void refresh() 
        {
            ItemTextBox.Text = "";
            QuantityTextBox.Text = "";

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " INSERT INTO hotel_inventory(Goods,Quantity) VALUES('" + ItemTextBox.Text + "','" + QuantityTextBox.Text + "'); ";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from hotel_inventory ;";

                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Iitem , " + ItemTextBox.Text + "' Is added ");
                    refresh();
                   // this.Hide();

                }
               // this.Close();
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }
        String id = "";
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ItemTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           QuantityTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            metroButton2.Visible = true;

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           

            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " UPDATE  hotel_inventory SET Goods='" + ItemTextBox.Text + "', Quantity='" + QuantityTextBox.Text + "' where id='" + id + "'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from hotel_inventory ;";

                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Iitem , " + ItemTextBox.Text + "' has been updated ");
                    refresh();
                   // this.Hide();

                }
               // this.Close();
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void htmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
