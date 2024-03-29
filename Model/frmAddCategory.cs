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
using MySql.Data.MySqlClient;

namespace JOLLIBURGER.Views
{
    public partial class frmAddCategory : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        //MySqlDataReader dr;
        //frmCategory f1;

        public frmAddCategory()
       // public frmAddCategory(frmCategory frm1)
        {
            InitializeComponent();
          // cn = new MySqlConnection(DBcon.MyConnection());
         //   f1 = frm1;

        }

        public int id = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCategory.Text == string.Empty)
            {
                MessageBox.Show("Required missing fields!","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string qry = "";

                if (id == 0)
                {
                    qry = "INSERT INTO tblcategory VALUES (@, @Name)";
                MessageBox.Show("Saved Successfully!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    qry = "UPDATE tblcategory SET categoryname = @Name WHERE categoryid = @id";
                MessageBox.Show("Changes Updated!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@Name", txtCategory.Text);

                if (MainClass.SQL(qry, ht) > 0)
                {
                    id = 0;
                    //txtCategory.Focus();
                    this.Dispose();
                }
            }
           
        
        //try
        //{
        //    if ((txtCategory.Text == string.Empty))
        //    {
        //        MessageBox.Show("Warning: Required missing fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    cn.Open();
        //    cm = new MySqlCommand("INSERT INTO tblcategory(categoryname) VALUES (@categoryname)", cn);
        //    cm.Parameters.AddWithValue("@categoryname", txtCategory.Text);
        //    cm.ExecuteNonQuery();
        //    cn.Close();
        //    MessageBox.Show("Category has been successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    Clear();
        //    f1.LoadCategory();
        //    this.Dispose();

        //}
        //catch (Exception ex)
        //{
        //    cn.Close();
        //    MessageBox.Show("Warning: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //}


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
