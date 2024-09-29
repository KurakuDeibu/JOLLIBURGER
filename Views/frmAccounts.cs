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
    public partial class frmAccounts : Form
    {
        MySqlConnection cn = new MySqlConnection();
        DBConnection DBcon = new DBConnection();
        public frmAccounts()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAccounts frm = new frmAccounts();
            //frm.btnSave.Enabled = true;
            //frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        public void LoadAccount()
        {
            try
            {

                cn.Open();
                dataGridView1.Rows.Clear();

                MySqlCommand cm = new MySqlCommand("select * from tblaccounts", cn);
                MySqlDataReader dr = cm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i += 1;
                    i = dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["id"].Value = dr["dgv_id"].ToString();
                    dataGridView1.Rows[i].Cells["user"].Value = dr["username"].ToString();
                    dataGridView1.Rows[i].Cells["password"].Value = dr["dgv_pass"].ToString();
                    dataGridView1.Rows[i].Cells["name"].Value = dr["dgv_name"].ToString();
                    dataGridView1.Rows[i].Cells["name"].Value = dr["dgv_name"].ToString();

                }

                dr.Close();
                cn.Close();

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
    }
}
