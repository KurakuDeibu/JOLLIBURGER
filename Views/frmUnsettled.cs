using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOLLIBURGER.Views
{
    public partial class frmUnsettled : Form
    {

        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();

        public frmUnsettled()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());
        }

        public void LoadOrder()
        {
            cn.Open();
            cm = new MySqlCommand("SELECT * FROM tblcustomer", cn);
            dr = cm.ExecuteReader();
            foreach (DbDataRecord record in dr)
            {
                Panel panelOrder = new Panel();
                panelOrder.Width = 200;
                panelOrder.Height = 100;
                panelOrder.BorderStyle = BorderStyle.None;
                panelOrder.BackColor = Color.DarkOrange;
                panelOrder.ForeColor = Color.White;


                Button CustomerID = new Button();
                CustomerID.BackColor = Color.White;
                CustomerID.ForeColor = Color.DarkOrange;
                CustomerID.Text = record["customerid"].ToString();
                CustomerID.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                CustomerID.Dock = DockStyle.Top;
                CustomerID.Cursor = Cursors.Hand;
                CustomerID.TextAlign = ContentAlignment.MiddleLeft;


                panelOrder.Controls.Add(CustomerID);
                flowLayoutPanel1.Controls.Add(panelOrder);

            }
            dr.Close();
            cn.Close();
        }

        private void frmUnsettled_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

