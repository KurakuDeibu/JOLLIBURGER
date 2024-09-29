using JOLLIBURGER.Model;
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JOLLIBURGER.Views
{
    public partial class frmProduct : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();

        public frmProduct() { 

            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());
            LoadRecords();

            }

            private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddProduct frm = new frmAddProduct();
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
            frm.LoadCategory();
            frm.ShowDialog();
        }

        public void LoadRecords()
        {
            try
            {
                cn.Open();
                dataGridView1.Rows.Clear();

                MySqlCommand cm = new MySqlCommand("select * from tblproducts WHERE name LIKE '%" + txtSearch.Text + "%'", cn);
                MySqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {   
                    int i = dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["image"].Value = Image.FromStream(new MemoryStream((byte[])dr["image"]));
                    dataGridView1.Rows[i].Cells["prodID"].Value = dr["prodID"].ToString();
                    dataGridView1.Rows[i].Cells["name"].Value = dr["name"].ToString();
                    dataGridView1.Rows[i].Cells["price"].Value = dr["price"].ToString();
                    dataGridView1.Rows[i].Cells["category"].Value = dr["category"].ToString();
                    dataGridView1.Rows[i].Cells["status"].Value = dr["status"].ToString();
                }

                dr.Close();
                cn.Close();

                for (int k = 0; k < dataGridView1.Rows.Count; k++)
                {
                    DataGridViewRow r = dataGridView1.Rows[k];
                    r.Height = 30;
                }

                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns["image"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void frmProduct_Load(object sender, EventArgs e)
        {
 
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colname == "dgvEDIT")
            {
                frmAddProduct frm = new frmAddProduct();

                {
                    cn.Open();
                    
                    cm = new MySqlCommand("SELECT image from tblproducts WHERE prodID LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);

                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        long len = dr.GetBytes(0, 0, null, 0, 0);
                        byte[] array = new byte[len];
                        dr.GetBytes(0, 0, array, 0, (int)len);
                        MemoryStream ms = new MemoryStream(array);
                        Bitmap bitmap = new Bitmap(ms);
                        frm.txtImage.BackgroundImage = bitmap;
                        frm.txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        frm.txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        frm.txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                        frm.cmbCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                        frm.cmbStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    }
                    dr.Close();
                    cn.Close();
                    frm.label1.Text = "EDIT PRODUCT";
                    frm.LoadCategory();
                    frm.btnSave.Enabled = false;
                    frm.btnUpdate.Enabled = true;
                    frm.ShowDialog();
                //Fix thiSSSSSSSSSSSS! later
                }
            }
            else if (colname == "dgvDELETE")
            {
                if (MessageBox.Show("Delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("DELETE FROM tblproducts WHERE prodID like @id", cn);
                    cm.Parameters.AddWithValue("@id", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //frmMenu frm = new frmMenu();
            //frm.Show();
            //this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmReport frm = new frmReport();
            frm.ShowDialog();
            frm.LoadReport();
        }
    }
}
