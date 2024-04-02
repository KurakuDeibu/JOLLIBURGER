namespace JOLLIBURGER.Views
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ucProducts1 = new JOLLIBURGER.ucProducts();
            this.ucProducts2 = new JOLLIBURGER.ucProducts();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dvg_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvg_amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.showPanel = new System.Windows.Forms.Panel();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ucProducts3 = new JOLLIBURGER.ucProducts();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ProductPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.showPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(140, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 71);
            this.label2.TabIndex = 6;
            this.label2.Text = "JOLLIBURGER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Order";
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.ucProducts1);
            this.ProductPanel.Controls.Add(this.ucProducts2);
            this.ProductPanel.Controls.Add(this.ucProducts3);
            this.ProductPanel.Location = new System.Drawing.Point(152, 160);
            this.ProductPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(556, 537);
            this.ProductPanel.TabIndex = 6;
            this.ProductPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ucProducts1
            // 
            this.ucProducts1.id = 0;
            this.ucProducts1.Location = new System.Drawing.Point(3, 3);
            this.ucProducts1.Name = "ucProducts1";
            this.ucProducts1.pcategory = null;
            this.ucProducts1.PImage = ((System.Drawing.Image)(resources.GetObject("ucProducts1.PImage")));
            this.ucProducts1.PName = "Product Name";
            this.ucProducts1.pprice = null;
            this.ucProducts1.Size = new System.Drawing.Size(189, 184);
            this.ucProducts1.TabIndex = 0;
            // 
            // ucProducts2
            // 
            this.ucProducts2.id = 0;
            this.ucProducts2.Location = new System.Drawing.Point(198, 3);
            this.ucProducts2.Name = "ucProducts2";
            this.ucProducts2.pcategory = null;
            this.ucProducts2.PImage = ((System.Drawing.Image)(resources.GetObject("ucProducts2.PImage")));
            this.ucProducts2.PName = "Product Name";
            this.ucProducts2.pprice = null;
            this.ucProducts2.Size = new System.Drawing.Size(189, 184);
            this.ucProducts2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(716, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 712);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 639);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "Place Order";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 609);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 609);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvg_id,
            this.dvg_name,
            this.dvg_qty,
            this.dvg_price,
            this.dvg_amt});
            this.dataGridView1.Location = new System.Drawing.Point(9, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(498, 428);
            this.dataGridView1.TabIndex = 8;
            // 
            // dvg_id
            // 
            this.dvg_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dvg_id.HeaderText = "id";
            this.dvg_id.MinimumWidth = 8;
            this.dvg_id.Name = "dvg_id";
            this.dvg_id.Width = 57;
            // 
            // dvg_name
            // 
            this.dvg_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dvg_name.HeaderText = "Name";
            this.dvg_name.MinimumWidth = 8;
            this.dvg_name.Name = "dvg_name";
            // 
            // dvg_qty
            // 
            this.dvg_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dvg_qty.HeaderText = "Qty";
            this.dvg_qty.MinimumWidth = 8;
            this.dvg_qty.Name = "dvg_qty";
            this.dvg_qty.Width = 69;
            // 
            // dvg_price
            // 
            this.dvg_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dvg_price.HeaderText = "Price";
            this.dvg_price.MinimumWidth = 8;
            this.dvg_price.Name = "dvg_price";
            this.dvg_price.Width = 80;
            // 
            // dvg_amt
            // 
            this.dvg_amt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dvg_amt.HeaderText = "Amt.";
            this.dvg_amt.MinimumWidth = 8;
            this.dvg_amt.Name = "dvg_amt";
            this.dvg_amt.Width = 78;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1236, 84);
            this.panel3.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::JOLLIBURGER.Properties.Resources.cross_small;
            this.btnExit.Location = new System.Drawing.Point(38, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 47);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 12;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.label6);
            this.showPanel.Controls.Add(this.txtSearch);
            this.showPanel.Controls.Add(this.CategoryPanel);
            this.showPanel.Controls.Add(this.ProductPanel);
            this.showPanel.Controls.Add(this.label1);
            this.showPanel.Controls.Add(this.panel3);
            this.showPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPanel.Location = new System.Drawing.Point(0, 0);
            this.showPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(1236, 712);
            this.showPanel.TabIndex = 4;
            this.showPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.showPanel_Paint);
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Location = new System.Drawing.Point(12, 163);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(133, 534);
            this.CategoryPanel.TabIndex = 7;
            // 
            // ucProducts3
            // 
            this.ucProducts3.id = 0;
            this.ucProducts3.Location = new System.Drawing.Point(3, 193);
            this.ucProducts3.Name = "ucProducts3";
            this.ucProducts3.pcategory = null;
            this.ucProducts3.PImage = ((System.Drawing.Image)(resources.GetObject("ucProducts3.PImage")));
            this.ucProducts3.PName = "Product Name";
            this.ucProducts3.pprice = null;
            this.ucProducts3.Size = new System.Drawing.Size(189, 184);
            this.ucProducts3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(150, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.txtSearch.Location = new System.Drawing.Point(155, 119);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(322, 34);
            this.txtSearch.TabIndex = 19;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.showPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ProductPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.showPanel.ResumeLayout(false);
            this.showPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel showPanel;
        private ucProducts ucProducts1;
        private ucProducts ucProducts2;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvg_amt;
        private ucProducts ucProducts3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
    }
}