using JOLLIBURGER.Model;
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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            //string qry = "SELECT prodId,pname,pprice,categoryname, c.categoryid FROM tblproducts p INNER JOIN tblcategory c on c.categoryid = p.categoryid WHERE pname LIKE '%" + txtSearch.Text + "%' ";

            string qry = "SELECT * FROM tblproducts WHERE pname LIKE '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgv_id);
            lb.Items.Add(dgv_name);
            lb.Items.Add(dgv_price);
           //lb.Items.Add(dgv_catid);
            lb.Items.Add(dgv_cat);

            MainClass.LoadData(qry, dataGridView1, lb);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddProduct frm = new frmAddProduct();
            //frm.btnSave.Enabled = true;
            //frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
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
    }
}
