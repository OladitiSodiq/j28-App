namespace HotelManagementSystemRoom
{
    partial class RoomsInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsInfo));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet1 = new HotelManagementSystemRoom.HotelDataSet1();
            this.roomsTableAdapter = new HotelManagementSystemRoom.HotelDataSet1TableAdapters.roomsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxroomRate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.Location = new System.Drawing.Point(248, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 59;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(97, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 58;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(490, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 36);
            this.label3.TabIndex = 57;
            this.label3.Text = "Rooms Information";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.Location = new System.Drawing.Point(175, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 29);
            this.textBox1.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Room Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomnoDataGridViewTextBoxColumn,
            this.roomtypeDataGridViewTextBoxColumn,
            this.roomrateDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(453, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 366);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // roomnoDataGridViewTextBoxColumn
            // 
            this.roomnoDataGridViewTextBoxColumn.DataPropertyName = "room_no";
            this.roomnoDataGridViewTextBoxColumn.HeaderText = "room_no";
            this.roomnoDataGridViewTextBoxColumn.Name = "roomnoDataGridViewTextBoxColumn";
            // 
            // roomtypeDataGridViewTextBoxColumn
            // 
            this.roomtypeDataGridViewTextBoxColumn.DataPropertyName = "room_type";
            this.roomtypeDataGridViewTextBoxColumn.HeaderText = "room_type";
            this.roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
            // 
            // roomrateDataGridViewTextBoxColumn
            // 
            this.roomrateDataGridViewTextBoxColumn.DataPropertyName = "room_rate";
            this.roomrateDataGridViewTextBoxColumn.HeaderText = "room_rate";
            this.roomrateDataGridViewTextBoxColumn.Name = "roomrateDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.hotelDataSet1;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(43, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 167);
            this.panel1.TabIndex = 61;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(1175, 386);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(58, 23);
            this.button_Update.TabIndex = 69;
            this.button_Update.Text = " Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Visible = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1046, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Room Rate";
            // 
            // textBoxroomRate
            // 
            this.textBoxroomRate.Location = new System.Drawing.Point(1126, 342);
            this.textBoxroomRate.Name = "textBoxroomRate";
            this.textBoxroomRate.Size = new System.Drawing.Size(176, 20);
            this.textBoxroomRate.TabIndex = 62;
            // 
            // RoomsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxroomRate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "RoomsInfo";
            this.Text = "RoomsInfo";
            this.Load += new System.EventHandler(this.RoomsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDataSet1 hotelDataSet1;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HotelDataSet1TableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxroomRate;
    }
}