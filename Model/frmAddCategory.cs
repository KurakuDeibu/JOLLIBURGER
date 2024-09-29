using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JOLLIBURGER.Model;
using MySql.Data.MySqlClient;

namespace JOLLIBURGER.Views
{
    public partial class frmAddCategory : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DBConnection DBcon = new DBConnection();

        public frmAddCategory()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());


        }

        public int id = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategory == null)
                {
                    MessageBox.Show("Category should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (MessageBox.Show("Save this category?", "Save Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("insert into tblcategory (categoryname) values (@category)", cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Category has been successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            frmAddProduct f1 = new frmAddProduct();
            f1.LoadCategory();
        }
           


        private void btnUpdate_Click(object sender, EventArgs e)
            {

            //    try
            //    {

            //        cn.Open();
            //        cm = new MySqlCommand("UPDATE tblcategory SET categoryname = '" + txtCategory.Text + "' WHERE categoryname LIKE '" + txtCategory.Text + "'", cn);
            //        // cm = new MySqlCommand("UPDATE tblcategory SET categoryname = '" + txtCategory.Text + "' WHERE categoryid LIKE  '" + txtCategory.Text + "'", cn);
            //        cm.Parameters.AddWithValue("@category", txtCategory.Text);
            //        cm.ExecuteNonQuery();
            //        cn.Close();
            //        MessageBox.Show("Category has been successfully updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        Clear();
            //        f1.LoadCategory();
            //        this.Dispose();
            //    }
            //    catch (Exception ex)
            //    {
            //        cn.Close();
            //        MessageBox.Show("Warning:" + ex.Message);

            //    }
            //
            }

        public void Clear()
        {
            // clear function for button function

            txtCategory.Clear();
         //   btnUpdate.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
