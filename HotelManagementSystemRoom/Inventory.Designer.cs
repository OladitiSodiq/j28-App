namespace HotelManagementSystemRoom
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.htmlLabel1 = new System.Windows.Forms.Label();
            this.htmlLabel2 = new System.Windows.Forms.Label();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.metroButton1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.htmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel1.Location = new System.Drawing.Point(23, 279);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(73, 17);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "Goods /Items";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.htmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel2.Location = new System.Drawing.Point(23, 331);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(73, 17);
            this.htmlLabel2.TabIndex = 1;
            this.htmlLabel2.Text = "Quantity";
            this.htmlLabel2.Click += new System.EventHandler(this.htmlLabel2_Click);
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Location = new System.Drawing.Point(96, 50);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(157, 20);
            this.ItemTextBox.TabIndex = 2;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(96, 99);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(157, 20);
            this.QuantityTextBox.TabIndex = 3;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(16, 165);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 35);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Save";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(541, 226);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(147, 165);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(95, 35);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Update";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Visible = false;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.QuantityTextBox);
            this.groupBox1.Controls.Add(this.ItemTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 224);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Inventory";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label htmlLabel1;
        private System.Windows.Forms.Label htmlLabel2;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button metroButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}