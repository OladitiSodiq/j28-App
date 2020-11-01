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
    public partial class Make_Sales : Form
    {
        public Make_Sales()
        {
            InitializeComponent();
        }
        
       
       
        public void funData(Label txtForm1)
        {
            attendantLabel.Text = txtForm1.Text;
        }

        string ConString = ConfigurationManager.ConnectionStrings["HotelManagementSystemRoom.Properties.Settings.HotelConnectionString"].ConnectionString;
        public string getCheckedFoodItems = "";
        public string getCheckedDrinksItems = "";
        public string getCheckedSnacksItems = "";
        public string filll1 = "";

        private void Make_Sales_Load(object sender, EventArgs e)
        {
            selectFood();
            
            selectDrinks();
            selectSnacks();
            loadActiveRoom();
            date_timeLabel.Text= DateTime.Now.ToString();

        }
        public void loadActiveRoomLodger() 
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string getCust = "select name from customer where roomno= '" + comboBox1.Text + "' and customer_status ='checkIn'";

                MySqlCommand cmd = new MySqlCommand(getCust, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    clientName.Text = dr.GetString(0);

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

                    comboBox1.Items.Add(filRoom);
                }

            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }
        public void selectFood()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string getCust = "select Menuname from Menu where category= 'food' ";

                MySqlCommand cmd = new MySqlCommand(getCust, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string fil1 = dr.GetString(0);

                    foodcheckedListBox.Items.Add(fil1);
                }

            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        public void selectDrinks()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string getCust = "select Menuname from Menu where category= 'Drinks' ";

                MySqlCommand cmd = new MySqlCommand(getCust, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string fil1 = dr.GetString(0);

                    drinkscheckedListBox.Items.Add(fil1);
                }

            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        public void selectSnacks()
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string getCust = "select Menuname from Menu where category= 'Snacks' ";

                MySqlCommand cmd = new MySqlCommand(getCust, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                string fil1 = dr.GetString(0);

                    snackscheckedListBox.Items.Add(fil1);
                }

            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

      
        private void snackscheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < snackscheckedListBox.Items.Count; i++)
            {
                if (snackscheckedListBox.GetItemChecked(i))
                {
                    getCheckedSnacksItems = (string)snackscheckedListBox.Items[i];

                }
            }
        }
       
        private void foodcheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < foodcheckedListBox.Items.Count; i++)
            {
                if (foodcheckedListBox.GetItemChecked(i))
                {
                    getCheckedFoodItems = (string)foodcheckedListBox.Items[i];
                   
                }
            }
        }

        private void drinkscheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < drinkscheckedListBox.Items.Count; i++)
            {
                if (drinkscheckedListBox.GetItemChecked(i))
                {
                    getCheckedDrinksItems = (string)drinkscheckedListBox.Items[i];
                  
                }
            }


        }
        public void selectPrice(string priceSelcetor)
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string getCust = "select price from Menu where Menuname= '" + priceSelcetor + "'";

                MySqlCommand cmd = new MySqlCommand(getCust, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                   filll1 = dr.GetString(0);    

                }

            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (foodQuantity.Text == "")
            {
                MessageBox.Show("Quantity can not be empty");
            }
            else
            { 
                selectPrice(getCheckedFoodItems);
                int foodtotal, foodquantity, foodprice;

                foodprice = int.Parse(filll1);
                foodquantity = int.Parse(foodQuantity.Text);
                foodtotal = foodprice * foodquantity;
                foodsTotal.Text = foodtotal.ToString();


                food_Label.Text = getCheckedFoodItems;
                food_quantityLabel.Text= foodquantity.ToString();
                food_totalLabel.Text= foodtotal.ToString();
                food_priceLabel.Text =foodprice.ToString();
               // food_Label.Visible = true;
                //food_quantityLabel.Visible = true;
                //food_totalLabel.Visible = true;
                //food_priceLabel.Visible = true;
                listBox1.Items.Add(getCheckedFoodItems + " |     " + foodquantity + " |   " + foodprice + "|   " + foodtotal);
            }

        }

        private void buttonCalculateDrink_Click(object sender, EventArgs e)
        {
            if (drinksQuantity.Text == "")
            {
                MessageBox.Show("Quantity can not be empty");
            }
            else
            {
                selectPrice(getCheckedDrinksItems);
                int total, quantity, price;

                price = int.Parse(filll1);
                quantity = int.Parse(drinksQuantity.Text);
                total = price * quantity;
                drimksTotal.Text = total.ToString();

                drinks_Label.Text = getCheckedDrinksItems;
                drinks_quantityLabel.Text = quantity.ToString();
                drinks_totalLabel.Text = total.ToString();
                drinks_priceLabel.Text = price.ToString();
             //   drinks_Label.Visible = true;
             //   drinks_quantityLabel.Visible = true;
               // drinks_totalLabel.Visible = true;
                //drinks_priceLabel.Visible = true;
                listBox1.Items.Add(getCheckedDrinksItems + " |     " + quantity + " |   " + price + "|   " + total);
            }

        }

        private void buttonCalculateSnacks_Click(object sender, EventArgs e)
        {
            if (snacksQuantity.Text == "")
            {
                MessageBox.Show("Quantity can not be empty");
            }
            else
            {
                selectPrice(getCheckedSnacksItems);
                int total, quantity, price;

                price = int.Parse(filll1);
                quantity = int.Parse(snacksQuantity.Text);
                total = price * quantity;
                snacksTotal.Text = total.ToString();
                snacks_priceLabel.Text = price.ToString();
                snacks_label.Text = getCheckedSnacksItems;
                snacks_quantityLabel.Text = quantity.ToString();
                snacks_totalLabel.Text = total.ToString();

               // snacks_label.Visible = true;
                //snacks_priceLabel.Visible = true;
                //snacks_quantityLabel.Visible = true;
                //snacks_totalLabel.Visible = true;
                listBox1.Items.Add(getCheckedSnacksItems + " |     " + quantity + " |   " + price + "|   " + total);
            }

        }
        Bitmap bitmap;
        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            this.Controls.Add(panel1);
            Graphics grp = panel1.CreateGraphics();
            Size formSize = this.ClientSize;
            Size panelSize = panel1.Size;
            bitmap = new Bitmap(panel1.Width, panel1.Height, grp);
            grp = Graphics.FromImage(bitmap);

            Point panelLocation = PointToScreen(panel1.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 8, 12, panelSize);
            printPreviewDialog1.Document = printDocument1;
            //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("ppim", 285, 600);
           // printPreviewDialog1.PrintPreviewControl.Zoom = 1;
          
            printPreviewDialog1.ShowDialog();
           
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // e.Graphics.DrawImage(bitmap, 8, 12);

            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
          //  PaperSize("ppim", 285, 600);
            RectangleF bounds = new System.Drawing.RectangleF(0,0,247,516);
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        private void button2_Click(object sender, EventArgs e)
        { 
           
            if (checkBoxWalkingCustomer.Checked)
            {
                int SubTotal;
                SubTotal = int.Parse(food_totalLabel.Text) + int.Parse(drinks_totalLabel.Text) + int.Parse(snacks_totalLabel.Text);
                subTotalLlabel.Text = SubTotal.ToString();
             
                RoomSC.Text = textBoxRoomService.Text;
                RoomSC.Visible = true;
                textBoxRoomService.Visible = false;
                CashierSC.Text = textBoxCashierService.Text;
                CashierSC.Visible = true;
                textBoxCashierService.Visible = false;


                int OverallTotal;
                OverallTotal = int.Parse(textBoxRoomService.Text) + int.Parse(textBoxCashierService.Text) + int.Parse(subTotalLlabel.Text);
                OverallTotalLabel.Text = OverallTotal.ToString();
            }
            else
            {
                if (comboBox1.SelectedItem.ToString() == "")
                {
                    int SubTotal;
                    SubTotal = int.Parse(food_totalLabel.Text) + int.Parse(drinks_totalLabel.Text) + int.Parse(snacks_totalLabel.Text);
                    subTotalLlabel.Text = SubTotal.ToString();
                    RoomNo.Text = comboBox1.SelectedItem.ToString();
                    RoomNo.Visible = true;
                    comboBox1.Visible = false;
                    RoomSC.Text = textBoxRoomService.Text;
                    RoomSC.Visible = true;
                    textBoxRoomService.Visible = false;
                    CashierSC.Text = textBoxCashierService.Text;
                    CashierSC.Visible = true;
                    textBoxCashierService.Visible = false;


                    int OverallTotal;
                    OverallTotal = int.Parse(textBoxRoomService.Text) + int.Parse(textBoxCashierService.Text) + int.Parse(subTotalLlabel.Text);
                    OverallTotalLabel.Text = OverallTotal.ToString();
                }
                else
                {
                    MessageBox.Show("Please select room ");
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            loadActiveRoomLodger();
        }

    
        public void quantity_sold(string labelss,string label222)
        {
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                //string str = " UPDATE  Menu SET Menuname='" + textBoxName.Text + "', Price='" + textBoxPrice.Text + "', category='" + comboBox_Category.Text + "', quantity_bought='" + quantity_bought.Text + "' where id='" + id + "'";
                string str = "SELECT  quantity_sold FROM Menu WHERE Menuname='" + labelss + "'";
                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();


                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string quantity_sold;
                    quantity_sold = dr.GetString("quantity_sold");
                    int foodquantity_update;
                    foodquantity_update = int.Parse(quantity_sold) + int.Parse(label222);
                    MySqlConnection con1 = new MySqlConnection(ConString);
                    con1.Open();
                    string str1 = " UPDATE  Menu SET quantity_sold='" + foodquantity_update + "' where Menuname='" + labelss + "'";
                    MySqlCommand cmd1 = new MySqlCommand(str1, con1);
                    cmd1.ExecuteNonQuery();
                    con1.Close();

                }
                //this.Close();
            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        public void saveRecipt() 
        {
            string listeditem = "";
            foreach (var item in listBox1.Items)
            {
                listeditem += item.ToString() + "/n"; // /n to print each item on new line or you omit /n to print text on same line
            }
            MySqlConnection con = new MySqlConnection(ConString);
            con.Open();
            try
            {
                string str = " INSERT INTO food_recipt(DateTime,Attendant_name,item_bought,subTotal,RoomNo,RoomSC,CashierSC,Total,Method_of_payment,name_of_client) VALUES" +
                    "('" + date_timeLabel.Text + "','" + attendantLabel.Text + "','" + listeditem + "','" + subTotalLlabel.Text + "','" + RoomNo.Text + "','" + RoomSC.Text + "','" + CashierSC.Text + "','" + OverallTotalLabel.Text + "','" + comboBoxMethod_of_payment.Text + "','" + clientName.Text + "'); ";

                MySqlCommand cmd = new MySqlCommand(str, con);
                cmd.ExecuteNonQuery();


                string str1 = "select max(id) from food_recipt ;";

                MySqlCommand cmd1 = new MySqlCommand(str1, con);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Recipt No , " + dr.GetString(0) + "' Saved .. ");


                }

            }
            catch (MySqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }
        private void buttonSaveRecipt_Click(object sender, EventArgs e)
        {
            saveRecipt();
           // foodquantity_sold();
            if (food_Label.Text != "")
            { 
                quantity_sold(food_Label.Text, foodQuantity.Text);
            }
            if (drinks_Label.Text != "")
            {
                quantity_sold(drinks_Label.Text, drinksQuantity.Text);
            }
            if (snacks_label.Text != "")
            {
                quantity_sold(snacks_label.Text, snacksQuantity.Text);
            }

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           


        }

        private void checkBoxWalkingCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWalkingCustomer.Checked == true)
            {
                label11.Visible = false;
                comboBox1.Visible = false;
                RoomNo.Visible = false;
                label18.Visible = true;
                WalkingCustomerName.Visible = true;
            }
            else
            {
                label11.Visible = true;
                comboBox1.Visible = true;
                RoomNo.Visible = true;
                label18.Visible = false;
                WalkingCustomerName.Visible = false;
            }
           


        }

        private void checkBoxWalkingCustomer_CheckStateChanged(object sender, EventArgs e)
        {

        }
    }
}
