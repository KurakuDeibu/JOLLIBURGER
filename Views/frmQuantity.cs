using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOLLIBURGER.Views
{
    public partial class frmQuantity : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();

            public frmQuantity()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());
        }

        string id = "";
        double price = 0;

        private void frmQuantity_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                TransacOrder();
                this.Dispose();
                //cn.Open();
                //double qty;
                //if (double.TryParse(txtQty.Text, out qty))
                //{
                //    frmMenu frmMenu = new frmMenu();
                //    cm = new MySqlCommand("INSERT INTO tblorder (orderno, prodID, customerid, price, qty, user) VALUES (@orderno, @prodID, @custid, @price, @qty, @user)", cn);
                //    cm.Parameters.AddWithValue("@orderno", frmMenu.lblOrder.Text);
                //    cm.Parameters.AddWithValue("@prodID", id);
                //    cm.Parameters.AddWithValue("@price", price);
                //    cm.Parameters.AddWithValue("@qty", qty);
                //    cm.Parameters.AddWithValue("@custid", frmMenu.lblcustomer.Text);
                //    cm.Parameters.AddWithValue("@user", frmMenu.lbl_username.Text);
                //    cm.ExecuteNonQuery();
                //    cn.Close();
                //    frmMenu.GetOrder();

                //    cn.Open();
                //    cm = new MySqlCommand("UPDATE tblorder SET total = price * qty", cn);
                //    cm.ExecuteNonQuery();
                //    cn.Close();

                //    this.Dispose();
                //}
                //else
                //{
                //    MessageBox.Show("Invalid quantity value. Please enter a valid number.");
                //    cn.Close();
                //}             
            }
        }


        public void AddToOrder(string id, double price)
        {
            this.price = price;
            this.id = id;

        }

        public void TransacOrder()
        {
            cn.Open();
            double qty;
            frmMenu frm = new frmMenu();

            if (double.TryParse(txtQty.Text, out qty))
            {
                cm = new MySqlCommand("INSERT INTO tblorder (orderno, prodID, customerid, price, qty, user) VALUES (@orderno, @prodID, @custid, @price, @qty, @user)", cn);
                cm.Parameters.AddWithValue("@orderno", frm.lblOrder.Text);
                cm.Parameters.AddWithValue("@prodID", id);
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@qty", qty);
                cm.Parameters.AddWithValue("@custid", frm.lblcustomer.Text);
                cm.Parameters.AddWithValue("@user", frm.lbl_username.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                frm.GetOrder();

                cn.Open();
                cm = new MySqlCommand("UPDATE tblorder SET total = price * qty", cn);
                cm.ExecuteNonQuery();
                cn.Close();

            }
            else
            {
                MessageBox.Show("Invalid quantity value. Please enter a valid number.");
                cn.Close();
            }
        }
        //if (e.KeyCode == Keys.Escape)
        //{
        //    this.Dispose();
        //}
        //else if (e.KeyCode == Keys.Enter)
        //{
        //    frmMenu frm = new frmMenu();
        //    cn.Open();
        //    cm = new MySqlCommand("INSERT INTO tblorder (orderno, prodID, price, qty) VALUES (@orderno, @id, @price, @qty)", cn);
        //    // cm = new MySqlCommand("INSERT INTO tblorder (transacNo, prodID, price, qty, total, customerid, user");
        //    cm.Parameters.AddWithValue("@orderno", frm.lblOrder.Text);
        //    cm.Parameters.AddWithValue("@id", id);
        //    cm.Parameters.AddWithValue("@price", price);
        //    cm.Parameters.AddWithValue("@qty", (double.Parse(txtQty.Text)));
        //    //cm.Parameters.AddWithValue("@customerid", frm.lblcustid.Text);
        //    cm.ExecuteNonQuery();

        //    cn.Close();

        //    cn.Open();
        //    cm = new MySqlCommand("UPDATE  tblorder SET total = price * qty", cn);
        //    cm.ExecuteNonQuery();
        //    cn.Close();
        //    frm.GetOrder();
        //    this.Dispose();

        //}



        //public void GetOrder()
        //{
        //    try
        //    {
        //        frmMenu frm = new frmMenu();
        //        double _total = 0;
        //        cn.Open();
        //        cm = new MySqlCommand("SELECT c.orderid, p.name, c.price, c.qty, c.total FROM tblorder as c INNER JOIN tblproducts" +
        //            " as p on p.prodID = c.prodID WHERE c.orderno LIKE '" + frm.lblOrder.Text + "'", cn);
        //      //  cm.Parameters.AddWithValue("@custid", frm.lblOrder.Text);
        //        dr = cm.ExecuteReader();
        //        int i = 0;
        //        while (dr.Read())
        //        {
        //            //frm.dataGridView1.Rows.Add(frm.dataGridView1.Rows[i].Cells["name"].Value = dr["name"].ToString(),
        //            //frm.dataGridView1.Rows[i].Cells["price"].Value = dr["price"].ToString(),
        //            //frm.dataGridView1.Rows[i].Cells["qty"].Value = dr["qty"].ToString(),
        //            //frm.dataGridView1.Rows[i].Cells["total"].Value = Convert.ToDouble(dr["total"].ToString()));

        //            _total += Convert.ToDouble(dr["total"]);

        //            MessageBox.Show("OrderNo: " + frm.lblOrder.Text +"\r\n"
        //                + "CustomerID: " + frm.lblcustomer.Text + "\r\n"
        //                + "ProductName: "+dr["name"].ToString() +"\r\n"
        //                + "Price: " +dr["price"].ToString() + "\r\n"
        //                + "Quantity: " + dr["qty"].ToString() + "\r\n"
        //                + "Total: " +dr["total"].ToString(), 
        //                "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);



        //        }
        //        dr.Close();
        //        cn.Close();
        //        frm.lblTotal.Text = string.Format("{0:#,##0.00}", _total); //Total
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message); }
        //}

        private void frmQuantity_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }


       

        private void frmQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtQty.Text = "2";
            txtQty.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtQty.Text = "5";
            txtQty.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtQty.Text = "10";
            txtQty.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtQty.Text = "20";
            txtQty.Focus();
        }
    }
}
