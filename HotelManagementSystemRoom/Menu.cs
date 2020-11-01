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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        string ConString = ConfigurationManager.ConnectionStrings["HotelManagementSystemRoom.Properties.Settings.HotelConnectionString"].ConnectionString;
        public void refresh()
        {
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            comboBox_Category.Text = "";
        }
        private void addStaffbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                int quantity_sold = 0;
                string str = "INSERT INTO Menu(Menuname,price,category,quantity_bought,quantity_sold) VALUES('" + textBoxName.Text + "','" + textBoxPrice.Text + "','" + comboBox_Category.Text + "','" + quantity_bought.Text + "','" + quantity_sold + "'); ";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from Menu ;";

                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Menu , " + textBoxName.Text + "' Is added ");
                    loadData();
                    refresh();
                    //  this.Hide();

                }
                //this.Close();
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();

        }

        private void Menu_Load(object sender, EventArgs e)
        {


            loadData();
        }
        public void loadData()
        {
            using (MySqlConnection con = new MySqlConnection(ConString))
            {

                string str = "SELECT * FROM Menu";
                MySqlCommand cmd = new MySqlCommand(str, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
        string id = "";
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = true;
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox_Category.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            quantity_bought.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            
            button_Update.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " UPDATE  Menu SET Menuname='" + textBoxName.Text + "', Price='" + textBoxPrice.Text + "', category='" + comboBox_Category.Text + "', quantity_bought='" + quantity_bought.Text + "' where id='" + id + "'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from Menu ;";

                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Iitem , " + textBoxName.Text + "' has been updated ");
                    //this.Hide();
                    loadData();
                    refresh();

                }
               //this.Close();
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

        private void button_View_Click(object sender, EventArgs e)
        {

        }
    }
}
