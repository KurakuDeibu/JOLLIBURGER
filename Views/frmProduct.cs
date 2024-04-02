using JOLLIBURGER.Model;
using System;
using System.Collections;
using System.Windows.Forms;

namespace JOLLIBURGER.Views
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "SELECT prodId,pname,pprice, categoryname, pCatID FROM tblproducts INNER JOIN tblcategory on categoryid = pCatID WHERE pname LIKE '%" + txtSearch.Text + "%' ORDER BY prodId ASC";

            ListBox lb = new ListBox();
            lb.Items.Add(dgv_pid);
            lb.Items.Add(dgv_pname);
            lb.Items.Add(dgv_pprice);
            lb.Items.Add(dgv_pcategory);
            lb.Items.Add(dgv_pcatid);

            //string qry = @"SELECT * FROM tblproducts WHERE pname LIKE '%" + txtSearch.Text + "%' ";

            MainClass.LoadData(qry, dataGridView1, lb);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddProduct frm = new frmAddProduct();
            //frm.btnSave.Enabled = true;
            //frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
          //  MainClass.BlurBkg(new frmAddProduct());
            GetData();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEDIT")
            {
                frmAddProduct frm = new frmAddProduct();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgv_pid"].Value);
                frm.cID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgv_pcatid"].Value);
                frm.ShowDialog();
                GetData();
            }

            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvDELETE")

            {
                if (MessageBox.Show("Are you sure to delete this category? ", "Delete Category?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgv_pid"].Value);
                    string qry = "DELETE FROM tblproducts WHERE prodId =" + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);

                    MessageBox.Show("Product deleted! ", "Successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetData();

                }
            }
        }
    }
}
