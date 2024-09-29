using System;
using System.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JOLLIBURGER.Views
{
    public partial class frmCategory : Form
    {
        MySqlConnection cn = new MySqlConnection();
        //MySqlCommand cm = new MySqlCommand();
        //MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();

        public frmCategory()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());
        //    LoadCategory();

        }

        //public void LoadCategory()
        //{
        //    int i = 0;
        //    //dataGridView1.Rows.Clear();
        //    cn.Open();
        //    MySqlCommand cm = new MySqlCommand("SELECT * FROM tblcategory ORDER BY categoryname", cn);
        //    MySqlDataReader dr = cm.ExecuteReader();

        //    while (dr.Read())
        //    {
        //        i += 1;
        //        dataGridView1.Rows.Add(i, dr[1].ToString());
        //    }
        //    dr.Read();
        //    cn.Close();
        //}

        public void GetData()
        {
            string qry = "SELECT * FROM tblcategory WHERE categoryname LIKE '%" +txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgid);
            lb.Items.Add(dvgcategory);

            MainClass.LoadData(qry, dataGridView1, lb);
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
           GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCategory frm = new frmAddCategory();
            //frm.btnSave.Enabled = true;
            //frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            //if (colName == "colEdit")
            //{
            //    frmAddCategory frm = new frmAddCategory();
            //    frm.btnSave.Enabled = false;
            //    frm.txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    frm.ShowDialog();
            //}
            //else if (colName == "colDelete")
            //{
            //    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        cn.Open();
            //        MySqlCommand cm = new MySqlCommand("DELETE FROM tblcategory WHERE categoryname LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + "'", cn);
            //        cm.ExecuteNonQuery();
            //        cn.Close();
            //        MessageBox.Show("Record has been successfully deleted! ", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LoadCategory();
            //    }
            //}
        }
     

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.OwningColumn.Name == "colEdit")
                {
                    frmAddCategory frm = new frmAddCategory();
                    frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dvgid"].Value);
                    frm.txtCategory.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dvgcategory"].Value);
                    frm.ShowDialog();
                    GetData();
                }

                else if (dataGridView1.CurrentCell.OwningColumn.Name == "colDelete")

                {
                    if (MessageBox.Show("Are you sure to delete this category? ", "Delete Category?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dvgid"].Value);
                        string qry = "DELETE FROM tblcategory WHERE categoryid =" + id + "";
                        Hashtable ht = new Hashtable();
                        MainClass.SQL(qry, ht);
                        MessageBox.Show("Category deleted! ", "Category Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetData();

                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
    }
