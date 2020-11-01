using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystemRoom
{
    public partial class RoomsInfo : Form
    {
        public RoomsInfo()
        {
            InitializeComponent();
        }
        public static string retrieveRole;

        public void funData(Label txtForm1)
        {
            retrieveRole = txtForm1.Text;
        }
        
        string ConString = ConfigurationManager.ConnectionStrings["HotelManagementSystemRoom.Properties.Settings.HotelConnectionString"].ConnectionString;
        private void RoomsInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.rooms' table. You can move, or remove it, as needed.
           // this.roomsTableAdapter.Fill(this.hotelDataSet1.rooms);
         

            using (MySqlConnection con = new MySqlConnection(ConString))
            {

                string str = "SELECT * FROM rooms";
                MySqlCommand cmd = new MySqlCommand(str, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
            
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Valid Room Id");
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(ConString))
                {

                    string str = "SELECT * FROM rooms WHERE room_no = '" + textBox1.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(str, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        string id = "";
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (retrieveRole == "manager") 
            { 
            textBoxroomRate.Visible = true;
            textBoxroomRate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            button_Update.Visible = true;
            }
            else
            {
                MessageBox.Show("No priviledge to perform Operation");
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
            //    string str = " UPDATE  rooms SET room_rate='" + textBoxroomRate.Text + "' where id='" + id + "'";
                string str = " UPDATE  rooms SET room_rate='" + textBoxroomRate.Text + "' where room_no='" + id + "'";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from rooms ;";

                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Room ,  has been updated ");
                    //this.Hide();
                 

                }
                //this.Close();
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }
    }
}
