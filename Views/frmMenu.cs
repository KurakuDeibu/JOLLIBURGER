using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JOLLIBURGER.Model;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace JOLLIBURGER.Views
{
    public partial class frmMenu : Form
    {

        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();
        string _filter = "";

        public frmMenu()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());
            this.KeyPress += frmMenu_KeyPress;  
            this.KeyPreview = true;

            // Search feature
            txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
        }

        private void showPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadMenu();
            LoadCategory();
            GetOrder();
            this.KeyPreview = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }

        }

        //Manage Product Button
        private void btn_ManageProducts_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.LoadRecords();
            frm.ShowDialog();
        }

        //LoadMenu() Method to to Load Menus/Products into the flowlayout
        public void LoadMenu()
        {
            string peso = "₱";
            ProductPanel.AutoScroll = true;
            ProductPanel.Controls.Clear();
            cn.Open();

            //string searchTerm = txtSearch.Text.Trim();

            //SQL query to select products based on the category filter and availability status

            //string query = "SELECT image, prodID, name, price, status FROM tblproducts " +
            //               "WHERE category LIKE '" + _filter + "%' AND status = 'AVAILABLE' AND name LIKE @SearchTerm " +
            //               "ORDER BY price";

            MySqlCommand cm = new MySqlCommand("SELECT image, prodID, name, price, status FROM tblproducts " +
                                                "WHERE category LIKE '" + _filter + "%' AND status = 'AVAILABLE' " +
                                                "ORDER BY price", cn);

            //MySqlCommand cm = new MySqlCommand(query, cn);

            MySqlDataReader dr = cm.ExecuteReader();

            foreach (DbDataRecord record in dr)
            {
                long len = record.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[len];
                record.GetBytes(0, 0, array, 0, (int)len);

                PictureBox picProduct = new PictureBox();
                picProduct.Width = 120;
                picProduct.Height = 80;
                picProduct.BackgroundImageLayout = ImageLayout.Stretch;
                picProduct.BorderStyle = BorderStyle.FixedSingle;
                picProduct.BackColor = Color.DarkOrange;
                picProduct.Cursor = Cursors.Hand;

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                picProduct.BackgroundImage = bitmap;
                picProduct.Tag = record["prodID"].ToString();


                Label lblProduct = new Label();
                lblProduct.BackColor = Color.White;
                lblProduct.ForeColor = Color.DarkOrange;
                lblProduct.Text = record["name"].ToString();
                lblProduct.Font = new Font("Segoe UI", 7, FontStyle.Bold);
                lblProduct.Dock = DockStyle.Top;
                lblProduct.Cursor = Cursors.Hand;
                lblProduct.TextAlign = ContentAlignment.MiddleLeft;
                lblProduct.Tag = record["prodID"].ToString();


                Label lblPrice = new Label();
                lblPrice.BackColor = Color.White;
                lblPrice.ForeColor = Color.DarkOrange;
                lblPrice.Text = peso + record["price"].ToString();
                lblPrice.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                lblPrice.Dock = DockStyle.Bottom;
                lblPrice.Cursor = Cursors.Hand;
                lblPrice.AutoSize = true;
                lblPrice.TextAlign = ContentAlignment.MiddleLeft;
                lblPrice.Tag = record["prodID"].ToString();

                picProduct.Controls.Add(lblPrice);
                picProduct.Controls.Add(lblProduct);
                ProductPanel.Controls.Add(picProduct);

                picProduct.Click += new EventHandler(select_Click);
                lblProduct.Click += new EventHandler(select_Click);
                lblPrice.Click += new EventHandler(select_Click);
            }

            dr.Close();
            cn.Close();
        }

        //LoadSearch method
        public void LoadSearch()
        {
            string peso = "₱";
            ProductPanel.AutoScroll = true;
            ProductPanel.Controls.Clear();

            // Get the search term from the txtSearch TextBox
            string searchTerm = txtSearch.Text.Trim();

            cn.Open();

            // SQL query to select products based on the search term and availability status
            string query = "SELECT image, prodID, name, price, status FROM tblproducts " +
                           "WHERE name LIKE @SearchTerm AND status = 'AVAILABLE' ORDER BY price";

            MySqlCommand cm = new MySqlCommand(query, cn);
            cm.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

            MySqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[len];
                dr.GetBytes(0, 0, array, 0, (int)len);

                PictureBox picProduct = new PictureBox();
                picProduct.Width = 120;
                picProduct.Height = 80;
                picProduct.BackgroundImageLayout = ImageLayout.Stretch;
                picProduct.BorderStyle = BorderStyle.FixedSingle;
                picProduct.BackColor = Color.DarkOrange;
                picProduct.Cursor = Cursors.Hand;

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                picProduct.BackgroundImage = bitmap;
                picProduct.Tag = dr["prodID"].ToString();

                Label lblProduct = new Label();
                lblProduct.BackColor = Color.White;
                lblProduct.ForeColor = Color.DarkOrange;
                lblProduct.Text = dr["name"].ToString();
                lblProduct.Font = new Font("Segoe UI", 7, FontStyle.Bold);
                lblProduct.Dock = DockStyle.Top;
                lblProduct.Cursor = Cursors.Hand;
                lblProduct.TextAlign = ContentAlignment.MiddleLeft;
                lblProduct.Tag = dr["prodID"].ToString();

                Label lblPrice = new Label();
                lblPrice.BackColor = Color.White;
                lblPrice.ForeColor = Color.DarkOrange;
                lblPrice.Text = peso + dr["price"].ToString();
                lblPrice.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                lblPrice.Dock = DockStyle.Bottom;
                lblPrice.Cursor = Cursors.Hand;
                lblPrice.AutoSize = true;
                lblPrice.TextAlign = ContentAlignment.MiddleLeft;
                lblPrice.Tag = dr["prodID"].ToString();

                picProduct.Controls.Add(lblPrice);
                picProduct.Controls.Add(lblProduct);
                ProductPanel.Controls.Add(picProduct);

                picProduct.Click += select_Click;
                lblProduct.Click += select_Click;
                lblPrice.Click += select_Click;
            }

            dr.Close();
            cn.Close();
        }


        //LoadCategory() Method to Select categories, and category filtering
        public void LoadCategory()
        {
            flowLayoutPanel1.Controls.Clear();

            cn.Open();
            cm = new MySqlCommand("SELECT * FROM tblcategory", cn);
            dr = cm.ExecuteReader();

            foreach (DbDataRecord record in dr)
            {
                Button btnCategory = new Button();
                btnCategory.Width = 80;
                btnCategory.Height = 30;
                btnCategory.Text = record["categoryname"].ToString();
                btnCategory.FlatStyle = FlatStyle.Flat;
                btnCategory.FlatAppearance.BorderColor = Color.DarkOrange;
                btnCategory.FlatAppearance.BorderSize = 1;
                btnCategory.BackColor = Color.White;
                btnCategory.ForeColor = Color.DarkOrange;
                btnCategory.Cursor = Cursors.Hand;
                //  btnCategory.TextAlign = ContentAlignment.MiddleLeft;
                flowLayoutPanel1.Controls.Add(btnCategory);

                btnCategory.Click += (sender, e) => { _filter = ((Button)sender).Text; LoadMenu(); };

            }
            dr.Close();
            cn.Close(); 
        }


        //Product select_click to show formQuantity, get id and price
        public void select_Click(object sender, EventArgs e)
        {
            try {
                double price = 0;
                string id = ((Control)sender).Tag.ToString();
                cn.Open();
                cm = new MySqlCommand("SELECT * FROM tblproducts WHERE prodID LIKE '" + id + "'", cn);
                dr = cm.ExecuteReader();
                
                dr.Read();
                if (dr.HasRows)
                {
                    price = double.Parse(dr["price"].ToString());
                }
                dr.Close();
                cn.Close();
                frmQuantity frm = new frmQuantity();
                frm.AddToOrder(id, price);
                frm.ShowDialog();
                GetOrder();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 

        }





        // GetOrder() Method to Select products from db

        public void GetOrder()
        {
            try
            {
                dataGridView1.Rows.Clear();

                double _total = 0;
                cn.Open();

                //cm = new MySqlCommand("SELECT c.orderid, p.name, c.price, c.qty, c.total FROM tblorder as c INNER JOIN tblproducts" +
                //" as p on p.prodID = c.prodID WHERE c.orderno LIKE '" + lblOrder.Text + "' ", cn);

                cm = new MySqlCommand("SELECT c.orderid, p.name, c.price, c.qty, c.total " +
                                       "FROM tblorder AS c " +
                                       "INNER JOIN tblproducts AS p ON p.prodID = c.prodID " +
                                       "WHERE c.customerid LIKE @orderNo AND c.status = 'Pending'", cn);


                //" as p on p.prodID = c.prodID", cn);
                cm.Parameters.AddWithValue("@orderNo", lblcustomer.Text);

                dr = cm.ExecuteReader();


                while (dr.Read())
                {
                    _total += Convert.ToDouble(dr["total"]);
                    dataGridView1.Rows.Add(dr["orderid"].ToString(), dr["name"].ToString(), dr["price"].ToString()
                        , dr["qty"].ToString(), dr["total"].ToString());


                    //MessageBox.Show("OrderNo: " + lblOrder.Text + "\r\n"
                    //    + "CustomerID: " + lblcustomer.Text + "\r\n"
                    //    + "ProductName: " + dr["name"].ToString() + "\r\n"
                    //    + "Price: " + dr["price"].ToString() + "\r\n"
                    //    + "Quantity: " + dr["qty"].ToString() + "\r\n"
                    //    + "Total: " + dr["total"].ToString(),
                    //    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                dr.Close();
                cn.Close();
                lblTotal.Text = string.Format("{0:#,##0.00}", _total); //Total
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }


        // GetOrder() Method backup
        //public void GetOrder()
        //{
        //    dataGridView1.Rows.Clear();
        //    double _total = 0;
        //    cn.Open();
        //    cm = new MySqlCommand("SELECT c.orderid, p.name, c.price, c.qty , c.total FROM tblorder as c INNER JOIN tblproducts as p on p.prodID = c.prodID WHERE c.orderno LIKE '" + lblOrder.Text + "'", cn);
        //    dr = cm.ExecuteReader();
        //    //int i = 0;
        //    while (dr.Read())
        //    {
        //        dataGridView1.Rows.Add(dr["orderid"], dr["name"], dr["price"], dr["qty"], dr["total"]);
        //        _total += Convert.ToDouble(dr["total"]);
        //        //dataGridView1.Rows.Add(dr["orderid"].ToString(), dr["name"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["total"].ToString());


        //    }
        //    dr.Close();
        //    cn.Close();
        //    lblTotal.Text = string.Format("{0:#,##0.00}", _total); //Total
        //}



        // Product Filtering

        public void filter_Click(object sender, EventArgs e)
        {
            if (lblOrder.Text == null)
            {
                MessageBox.Show("Please choose the customer first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                _filter = sender.ToString();
                LoadMenu(); 

        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadSearch();
            LoadCategory();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadMenu();
        }

        //New Order Button
        private void newOrder_Click(object sender, EventArgs e)
        {
            lblOrder.Text = GetOrderNo();


            //frmOrders frm = new frmOrders();
            //frm.LoadOrder();
            //frm.ShowDialog();


          //  autoID();
            GetOrder();
        }

        public void autoID()
        {
            try
            {
                string sql = "select MAX(customerid) from tblcustomer";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cn.Open();

                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                    lblcustomer.Text = "C-001";
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 3));
                    intval++;
                    lblcustomer.Text = String.Format("C-{0:000}", intval);
                }

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        public const string DateFormat = "yyyyMMdd";


        public string GetOrderNo()
        {
            string orderNo = string.Empty;

            try
            {
                cn.Open();
                using (var cm = new MySqlCommand("SELECT * FROM tblorder WHERE orderno LIKE @date ORDER BY orderid DESC", cn))
                {
                    cm.Parameters.AddWithValue("@date", DateTime.Now.ToString(DateFormat) + "%");
                    using (var dr = cm.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            orderNo = (long.Parse(dr["orderno"].ToString()) + 1).ToString();
                        }
                        else
                        {
                            orderNo += DateTime.Now.ToString(DateFormat) + "001";
                        }
                        dr.Close();
                        cn.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                cn.Close();
            }
            return orderNo;
        }


        //Backup GetOrderNo() Method

        //public const string DateFormat = "yyyyMMdd";


        //public string GetOrderNo()
        //{
        //    string orderNo = string.Empty;
        //    try
        //    {
        //        cn.Open();
        //            using (var cm = new MySqlCommand("SELECT * FROM tblorder WHERE orderno LIKE @date ORDER BY orderid DESC", cn))
        //            {
        //                cm.Parameters.AddWithValue("@date", DateTime.Now.ToString(DateFormat) + "%");
        //                using (var dr = cm.ExecuteReader())
        //                {
        //                    if (dr.Read())
        //                    {
        //                        orderNo = (long.Parse(dr["orderno"].ToString()) + 1).ToString();
        //                    }
        //                    else
        //                    {
        //                        orderNo = DateTime.Now.ToString(DateFormat) + "001";
        //                    }
        //                dr.Close();
        //                cn.Close();
        //                }
        //            }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //        cn.Close();
        //    }
        //    return orderNo;
        //}



        //Unsettled Orders Button
        private void unsettledOrder_Click(object sender, EventArgs e)
        {
            frmPayment frm = new frmPayment();
            frm.txtTotal.Text = lblTotal.Text;
            frm.ShowDialog();
        }

        //Add Customer Button
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.btnSave.Enabled = true;
            //frm.btnUpdate.Enabled = false;
            //  frm.LoadCategory();
            frm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //F1 Keys to display Order Form
        private void frmMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
          

        }


        // dataGridView1 - Content Click for Updating and Deleting
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView1.Columns[e.ColumnIndex].Name;

            if (colname == "dgvDELETE")
            {
                if (MessageBox.Show("Remove this item from order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("DELETE FROM tblorder WHERE orderid like @id", cn);
                    cm.Parameters.AddWithValue("@id", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item deleted", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetOrder();
                }
            }
        }
        
        // For Reloading Order Cart
        private void button1_Click(object sender, EventArgs e)
        {
            GetOrder();
            LoadMenu();
        }

        private void lblcustomer_TextChanged(object sender, EventArgs e)
        {
            GetOrder();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSearch();

        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                // Show frmOrder form
                newOrder_Click(sender, e);
            } else if (e.KeyCode == Keys.F2)
            {
                Pay_btn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                AddCustomer_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                btn_ManageProducts_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnCompleted_Click(sender, e);
            }
        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            frmPayment frm = new frmPayment();
            frm.txtTotal.Text = lblTotal.Text;
            frm.ShowDialog();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            frmCompletedOrder frm = new frmCompletedOrder();
            frm.ShowDialog();
        }

        private void lblOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
            }
        }
    }
}
