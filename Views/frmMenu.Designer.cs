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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.TextBox();
            this.lblcustomer = new System.Windows.Forms.TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.Pay_btn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.showPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAll = new System.Windows.Forms.Label();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.unsettledOrder = new System.Windows.Forms.Button();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btn_ManageProducts = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ucProducts1 = new JOLLIBURGER.ucProducts();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.showPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOrder);
            this.panel2.Controls.Add(this.lblcustomer);
            this.panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_username);
            this.panel2.Controls.Add(this.Pay_btn);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(732, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 637);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblOrder
            // 
            this.lblOrder.Location = new System.Drawing.Point(149, 117);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.ReadOnly = true;
            this.lblOrder.Size = new System.Drawing.Size(264, 30);
            this.lblOrder.TabIndex = 27;
            this.lblOrder.TextChanged += new System.EventHandler(this.lblOrder_TextChanged);
            // 
            // lblcustomer
            // 
            this.lblcustomer.Location = new System.Drawing.Point(331, 75);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.ReadOnly = true;
            this.lblcustomer.Size = new System.Drawing.Size(221, 30);
            this.lblcustomer.TabIndex = 26;
            this.lblcustomer.Text = " ";
            this.lblcustomer.TextChanged += new System.EventHandler(this.lblcustomer_TextChanged);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::JOLLIBURGER.Properties.Resources.icons8_admin_50;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(20, 14);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(117, 106);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2CirclePictureBox1.TabIndex = 19;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodID,
            this.name,
            this.price,
            this.qty,
            this.total,
            this.dgvDELETE});
            this.dataGridView1.GridColor = System.Drawing.Color.Linen;
            this.dataGridView1.Location = new System.Drawing.Point(20, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(532, 414);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prodID
            // 
            this.prodID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodID.HeaderText = "ID";
            this.prodID.MinimumWidth = 8;
            this.prodID.Name = "prodID";
            this.prodID.ReadOnly = true;
            this.prodID.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 92;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 79;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 92;
            // 
            // dgvDELETE
            // 
            this.dgvDELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvDELETE.HeaderText = "DEL";
            this.dgvDELETE.Image = global::JOLLIBURGER.Properties.Resources.trash_xmark;
            this.dgvDELETE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDELETE.MinimumWidth = 8;
            this.dgvDELETE.Name = "dgvDELETE";
            this.dgvDELETE.ReadOnly = true;
            this.dgvDELETE.Width = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Customer Name :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(149, 583);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 41);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Order # :";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(308, 28);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(126, 25);
            this.lbl_username.TabIndex = 15;
            this.lbl_username.Text = "Super Admin";
            // 
            // Pay_btn
            // 
            this.Pay_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.Pay_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pay_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.Pay_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pay_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pay_btn.Location = new System.Drawing.Point(348, 580);
            this.Pay_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pay_btn.Name = "Pay_btn";
            this.Pay_btn.Size = new System.Drawing.Size(204, 54);
            this.Pay_btn.TabIndex = 15;
            this.Pay_btn.Text = "&PAY NOW";
            this.Pay_btn.UseVisualStyleBackColor = false;
            this.Pay_btn.Click += new System.EventHandler(this.Pay_btn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::JOLLIBURGER.Properties.Resources.icons8_logout_50;
            this.btnExit.Location = new System.Drawing.Point(509, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 39);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 12;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cashier Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 583);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "TOTAL :";
            // 
            // newOrder
            // 
            this.newOrder.BackColor = System.Drawing.Color.SandyBrown;
            this.newOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newOrder.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.newOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newOrder.Location = new System.Drawing.Point(14, 14);
            this.newOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(206, 54);
            this.newOrder.TabIndex = 11;
            this.newOrder.Text = "[F1 - New Order]";
            this.newOrder.UseVisualStyleBackColor = false;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1300, 18);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(131, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 71);
            this.label2.TabIndex = 6;
            this.label2.Text = "JOLLIBURGER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.panel5);
            this.showPanel.Controls.Add(this.flowLayoutPanel1);
            this.showPanel.Controls.Add(this.panel4);
            this.showPanel.Controls.Add(this.ProductPanel);
            this.showPanel.Controls.Add(this.panel2);
            this.showPanel.Controls.Add(this.panel3);
            this.showPanel.Controls.Add(this.pictureBox1);
            this.showPanel.Controls.Add(this.panel1);
            this.showPanel.Controls.Add(this.label2);
            this.showPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPanel.Location = new System.Drawing.Point(0, 0);
            this.showPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(1300, 740);
            this.showPanel.TabIndex = 4;
            this.showPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.showPanel_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SandyBrown;
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(130, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(602, 46);
            this.panel5.TabIndex = 18;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.White;
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::JOLLIBURGER.Properties.Resources.icons8_search_26;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txtSearch.Location = new System.Drawing.Point(359, 7);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(235, 34);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(16, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "PRODUCTS";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 142);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(127, 513);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SandyBrown;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblAll);
            this.panel4.Location = new System.Drawing.Point(3, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 47);
            this.panel4.TabIndex = 2;
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.BackColor = System.Drawing.Color.Transparent;
            this.lblAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAll.Location = new System.Drawing.Point(17, 6);
            this.lblAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(86, 32);
            this.lblAll.TabIndex = 18;
            this.lblAll.Text = "MENU";
            this.lblAll.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.ucProducts1);
            this.ProductPanel.Location = new System.Drawing.Point(130, 142);
            this.ProductPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(602, 513);
            this.ProductPanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JOLLIBURGER.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.unsettledOrder);
            this.panel1.Controls.Add(this.AddCustomer);
            this.panel1.Controls.Add(this.btnCompleted);
            this.panel1.Controls.Add(this.newOrder);
            this.panel1.Controls.Add(this.btn_ManageProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 655);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 85);
            this.panel1.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SandyBrown;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1080, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 54);
            this.button4.TabIndex = 16;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // unsettledOrder
            // 
            this.unsettledOrder.BackColor = System.Drawing.Color.SandyBrown;
            this.unsettledOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unsettledOrder.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.unsettledOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unsettledOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.unsettledOrder.Location = new System.Drawing.Point(228, 15);
            this.unsettledOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unsettledOrder.Name = "unsettledOrder";
            this.unsettledOrder.Size = new System.Drawing.Size(206, 54);
            this.unsettledOrder.TabIndex = 19;
            this.unsettledOrder.Text = "[F2 - Settle Payment]";
            this.unsettledOrder.UseVisualStyleBackColor = false;
            this.unsettledOrder.Click += new System.EventHandler(this.unsettledOrder_Click);
            // 
            // AddCustomer
            // 
            this.AddCustomer.BackColor = System.Drawing.Color.SandyBrown;
            this.AddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCustomer.Location = new System.Drawing.Point(442, 15);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(204, 54);
            this.AddCustomer.TabIndex = 18;
            this.AddCustomer.Text = "[F3 - Add Customer]";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleted.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompleted.Location = new System.Drawing.Point(868, 14);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(204, 54);
            this.btnCompleted.TabIndex = 16;
            this.btnCompleted.Text = "[F5-Completed Orders]";
            this.btnCompleted.UseVisualStyleBackColor = false;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btn_ManageProducts
            // 
            this.btn_ManageProducts.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_ManageProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageProducts.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_ManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ManageProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ManageProducts.Location = new System.Drawing.Point(656, 15);
            this.btn_ManageProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ManageProducts.Name = "btn_ManageProducts";
            this.btn_ManageProducts.Size = new System.Drawing.Size(204, 54);
            this.btn_ManageProducts.TabIndex = 17;
            this.btn_ManageProducts.Text = "[F4 - Manage Products]";
            this.btn_ManageProducts.UseVisualStyleBackColor = false;
            this.btn_ManageProducts.Click += new System.EventHandler(this.btn_ManageProducts_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.HeaderText = "DEL";
            this.dataGridViewImageColumn1.Image = global::JOLLIBURGER.Properties.Resources.trash_xmark;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // ucProducts1
            // 
            this.ucProducts1.id = 0;
            this.ucProducts1.Location = new System.Drawing.Point(2, 2);
            this.ucProducts1.Margin = new System.Windows.Forms.Padding(2);
            this.ucProducts1.Name = "ucProducts1";
            this.ucProducts1.pcategory = null;
            this.ucProducts1.PImage = ((System.Drawing.Image)(resources.GetObject("ucProducts1.PImage")));
            this.ucProducts1.PName = "Product Name";
            this.ucProducts1.pprice = null;
            this.ucProducts1.Size = new System.Drawing.Size(189, 158);
            this.ucProducts1.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 740);
            this.Controls.Add(this.showPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMenu_KeyPress);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.showPanel.ResumeLayout(false);
            this.showPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel showPanel;
        public System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button unsettledOrder;
        private System.Windows.Forms.Button Pay_btn;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private ucProducts ucProducts1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn dgvDELETE;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox lblcustomer;
        public System.Windows.Forms.TextBox lblOrder;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
        public System.Windows.Forms.Label lblAll;
        public System.Windows.Forms.Button btn_ManageProducts;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}