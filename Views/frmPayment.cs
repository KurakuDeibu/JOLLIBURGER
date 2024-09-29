using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOLLIBURGER.Views
{
    public partial class frmPayment : Form
    {   
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();

        public frmPayment()
        {

            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());
            txtCash.Focus();

        }

        private void txtCash_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case char c when (c >= '0' && c <= '9'):
                case '.':
                case '\b':
                case '\r':
                    if (e.KeyChar == '\r')
                    {
                        btnPayment_Click(sender, e);
                    }
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try { 
            double total = Convert.ToDouble(txtTotal.Text);
            double change = Convert.ToDouble(txtCash.Text) - total;

            if (change < 0)
            {
                txtChange.Text = "0.00";
            } else
            {
                txtChange.Text = string.Format("{0:#,##0.00}", change); //Change
            }
            } catch (Exception ex)
            {
                txtChange.Text = "0.00";
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(txtTotal.Text);
                double change = Convert.ToDouble(txtCash.Text) - total;

                if (change < 0)
                {
                    MessageBox.Show("Please enter sufficient amount!", "Insufficient Cash!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Save this payment?", "Processing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SavePayment();
                    }
                }
            }
            catch (Exception ex)
            {
                txtChange.Text = "0.00";
            }
        }

        public void SavePayment()
        {
            try
            {
                frmMenu frm = new frmMenu();
                string sdate = DateTime.Now.ToString("yyyy-MM-dd");
                string stime = DateTime.Now.ToString("hh:mm:55");

                cn.Open();
                cm = new MySqlCommand("INSERT INTO tblsales (orderno, total, sdate, stime, cashier) VALUES (@orderno, @total, @sdate, @stime, @cashier)", cn);

                cm.Parameters.AddWithValue("@orderno", frm.lblOrder.Text);
                cm.Parameters.AddWithValue("@total", Convert.ToDouble(txtTotal.Text));
                cm.Parameters.AddWithValue("@sdate", sdate);
                cm.Parameters.AddWithValue("@stime", stime);
                cm.Parameters.AddWithValue("@cashier", frm.lbl_username.Text);
                cm.ExecuteNonQuery();

                cn.Close();

             

                MessageBox.Show("Payment Successfull!", "PAYMENT DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Update Order
                cn.Open();
                cm = new MySqlCommand("UPDATE tblorder SET status = 'Completed' WHERE orderno LIKE '" +frm.lblOrder.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();

                frmMenu frm1 = new frmMenu();
                frm.lblOrder.Text = frm.GetOrderNo();
                frm.GetOrder();

                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
