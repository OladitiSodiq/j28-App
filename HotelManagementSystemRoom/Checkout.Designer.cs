namespace HotelManagementSystemRoom
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.comboBoxRoomSelection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.Label();
            this.roomCost = new System.Windows.Forms.Label();
            this.date_out = new System.Windows.Forms.Label();
            this.date_in = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.RoomNo = new System.Windows.Forms.Label();
            this.daysSpent = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.date_Time = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRoomSelection
            // 
            this.comboBoxRoomSelection.FormattingEnabled = true;
            this.comboBoxRoomSelection.Location = new System.Drawing.Point(599, 111);
            this.comboBoxRoomSelection.Name = "comboBoxRoomSelection";
            this.comboBoxRoomSelection.Size = new System.Drawing.Size(123, 21);
            this.comboBoxRoomSelection.TabIndex = 82;
            this.comboBoxRoomSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomSelection_SelectedIndexChanged);
            this.comboBoxRoomSelection.SelectedValueChanged += new System.EventHandler(this.comboBoxRoomSelection_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(512, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Room No";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(498, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 83;
            this.button4.Text = "Save Recipt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(343, 204);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 13);
            this.label31.TabIndex = 92;
            this.label31.Text = "Signature :";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(22, 204);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 13);
            this.label33.TabIndex = 90;
            this.label33.Text = "Name Of Client :";
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.Location = new System.Drawing.Point(157, 202);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(41, 13);
            this.clientName.TabIndex = 91;
            this.clientName.Text = "label12";
            // 
            // roomCost
            // 
            this.roomCost.AutoSize = true;
            this.roomCost.Location = new System.Drawing.Point(82, 170);
            this.roomCost.Name = "roomCost";
            this.roomCost.Size = new System.Drawing.Size(0, 13);
            this.roomCost.TabIndex = 100;
            // 
            // date_out
            // 
            this.date_out.AutoSize = true;
            this.date_out.Location = new System.Drawing.Point(336, 126);
            this.date_out.Name = "date_out";
            this.date_out.Size = new System.Drawing.Size(50, 13);
            this.date_out.TabIndex = 97;
            this.date_out.Text = "Date-Out";
            // 
            // date_in
            // 
            this.date_in.AutoSize = true;
            this.date_in.Location = new System.Drawing.Point(82, 126);
            this.date_in.Name = "date_in";
            this.date_in.Size = new System.Drawing.Size(42, 13);
            this.date_in.TabIndex = 96;
            this.date_in.Text = "Date-In";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(11, 170);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(59, 13);
            this.label48.TabIndex = 95;
            this.label48.Text = "Room Cost";
            // 
            // RoomNo
            // 
            this.RoomNo.AutoSize = true;
            this.RoomNo.Location = new System.Drawing.Point(82, 149);
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.Size = new System.Drawing.Size(49, 13);
            this.RoomNo.TabIndex = 93;
            this.RoomNo.Text = "RoomNo";
            // 
            // daysSpent
            // 
            this.daysSpent.AutoSize = true;
            this.daysSpent.Location = new System.Drawing.Point(336, 170);
            this.daysSpent.Name = "daysSpent";
            this.daysSpent.Size = new System.Drawing.Size(62, 13);
            this.daysSpent.TabIndex = 99;
            this.daysSpent.Text = "Days Spent";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(257, 170);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(62, 13);
            this.label51.TabIndex = 89;
            this.label51.Text = "Days Spent";
            // 
            // date_Time
            // 
            this.date_Time.AutoSize = true;
            this.date_Time.Location = new System.Drawing.Point(95, 103);
            this.date_Time.Name = "date_Time";
            this.date_Time.Size = new System.Drawing.Size(41, 13);
            this.date_Time.TabIndex = 88;
            this.date_Time.Text = "label11";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(11, 103);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(70, 13);
            this.label55.TabIndex = 87;
            this.label55.Text = "Date / Time :";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(257, 126);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(50, 13);
            this.label56.TabIndex = 86;
            this.label56.Text = "Date-Out";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(9, 126);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(42, 13);
            this.label57.TabIndex = 85;
            this.label57.Text = "Date-In";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(11, 149);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(52, 13);
            this.label58.TabIndex = 84;
            this.label58.Text = "Room No";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.clientName);
            this.panel1.Controls.Add(this.roomCost);
            this.panel1.Controls.Add(this.date_out);
            this.panel1.Controls.Add(this.date_in);
            this.panel1.Controls.Add(this.label48);
            this.panel1.Controls.Add(this.RoomNo);
            this.panel1.Controls.Add(this.daysSpent);
            this.panel1.Controls.Add(this.label51);
            this.panel1.Controls.Add(this.date_Time);
            this.panel1.Controls.Add(this.label55);
            this.panel1.Controls.Add(this.label56);
            this.panel1.Controls.Add(this.label57);
            this.panel1.Controls.Add(this.label58);
            this.panel1.Location = new System.Drawing.Point(16, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 245);
            this.panel1.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 103;
            this.label2.Text = "Check Out Receipt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Check Out Bill ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(619, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 102;
            this.button6.Text = "Print";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(498, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 17);
            this.checkBox1.TabIndex = 103;
            this.checkBox1.Text = "Check For Outstanding Payment";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBoxRoomSelection);
            this.Controls.Add(this.label3);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRoomSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.Label roomCost;
        private System.Windows.Forms.Label date_out;
        private System.Windows.Forms.Label date_in;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label RoomNo;
        private System.Windows.Forms.Label daysSpent;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label date_Time;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}