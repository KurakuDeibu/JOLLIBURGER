using Microsoft.Reporting.Map.WebForms.BingMaps;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace JOLLIBURGER.Views
{
    public partial class frmCompletedOrder : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();

            public frmCompletedOrder()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());

        }

        private void frmCompletedOrder_Load(object sender, EventArgs e)
        {
            LoadCompletedOrder();

        }

        
        public void LoadCompletedOrder()
        {
            try
            {
                double _total = 0;

                cn.Open();
                dataGridView1.Rows.Clear();

                MySqlCommand cm = new MySqlCommand("SELECT prodID, price, qty, total, sdate , status FROM tblorder WHERE status = 'Completed'", cn);

                MySqlDataReader dr = cm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i += 1;
                    i = dataGridView1.Rows.Add();
                    _total += Convert.ToDouble(dr["total"]);
                    dataGridView1.Rows[i].Cells["prodID"].Value = dr["prodID"].ToString();
                    dataGridView1.Rows[i].Cells["price"].Value = dr["price"].ToString();
                    dataGridView1.Rows[i].Cells["qty"].Value = dr["qty"].ToString();
                    dataGridView1.Rows[i].Cells["total"].Value = dr["total"].ToString();
                    dataGridView1.Rows[i].Cells["sdate"].Value = dr["sdate"].ToString();
                    dataGridView1.Rows[i].Cells["status"].Value = dr["status"].ToString();

                }

                dr.Close();
                cn.Close();

                lblTotal.Text = string.Format("{0:#,##0.00}", _total); //Total

                //for (int k = 0; k < dataGridView1.Rows.Count - 1; k++)
                //{
                //    DataGridViewRow r = dataGridView1.Rows[k];
                //    r.Height = 30;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
