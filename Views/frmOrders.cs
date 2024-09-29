using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOLLIBURGER.Views
{
    public partial class frmOrders : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();

        public frmOrders()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());
        }

        string custid = "Customer ID: \r\n";

        public void LoadOrder()
        {
            flowLayoutPanel1.AutoScroll = true;
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM tblcustomer", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Button CustomerID = new Button();
                CustomerID.Width = 120;
                CustomerID.Height = 80;
                CustomerID.BackColor = Color.White;
                CustomerID.ForeColor = Color.DarkOrange;
                CustomerID.Text = dr["customerid"].ToString();
                CustomerID.Tag = dr["customerid"].ToString();
                CustomerID.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                CustomerID.Dock = DockStyle.Top;
                CustomerID.Cursor = Cursors.Hand;
                CustomerID.TextAlign = ContentAlignment.MiddleLeft;

                flowLayoutPanel1.Controls.Add(CustomerID);
                CustomerID.Click += new EventHandler(GetCustomer_Click);
            }
            dr.Close();
            cn.Close();
        }

        private void GetCustomer_Click(object sender, EventArgs e)
        {
            //frmMenu frm = new frmMenu();
            //string _customer = ((Button)sender).Text;
            //frm.lblcustomer.Text.Replace(" ",_customer);
            //frm.lblOrder.Text.Replace(" ",GetOrderNo());
            //frm.Show();

            frmMenu frm = new frmMenu();
            string _customer = ((Button)sender).Text;
            frm.lblcustomer.Text = _customer;
            //frm.lblOrder.Text = frm.GetOrderNo();
            frm.ShowDialog();

        }



        //public string GetOrderNo()
        //{
        //    string orderNo = String.Empty;

        //    try
        //    {
        //        string sdate = DateTime.Now.ToString("yyyyMMdd");
        //        cn.Open();
        //        cm = new MySqlCommand("SELECT * FROM tblorder WHERE orderno LIKE '" + sdate + "%' ORDER BY orderid DESC", cn);
        //        dr = cm.ExecuteReader();

        //        if (dr.HasRows)
        //        {
        //            orderNo = (long.Parse(dr["orderno"].ToString()) + 1).ToString();
        //        }
        //        else
        //        {
        //            orderNo += sdate + "01";
        //        }
        //        dr.Close();
        //        cn.Close();
        //        //return orderNo;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //        cn.Close();
        //    }
        //    return orderNo;
        //}




        private void pictureBox1_Click(object sender, EventArgs e)
            {
                //this.Hide();
            }
        }
    }
