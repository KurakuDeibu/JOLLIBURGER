using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JOLLIBURGER.Model
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int cID = 0;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg";

            if(ofd.ShowDialog() == DialogResult.OK )
            {
                filePath = ofd.FileName;
                txtImage.Image = new Bitmap(filePath);
            }
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string qry = @"SELECT categoryid 'id' , categoryname 'name' FROM tblcategory ";
            MainClass.CBFILL(qry, cmbCategory);

            if(cID > 0) //for updating
            {
                cmbCategory.SelectedValue= cID;
            }

            if (id > 0)
            {
                ForUpdateLoadData();
            }
        }

        string filePath;
        Byte[] imageByteArray;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPName.Text == string.Empty || txtPrice.Text == string.Empty || cmbCategory.Text ==string.Empty) 
                {
                    MessageBox.Show("Please enter all fields", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            string qry = "";

            if(id == 0) // inserting
            {
                qry = "INSERT INTO tblproducts VALUES (@id, @prodname, @price, @cat, @img)";
            }
            else
            {
                qry = "UPDATE tblproducts SET pname = @prodname, pprice = @price, categoryname = @cat, pimage = @img WHERE prodId = @id";
            }

            //for image
            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms =new MemoryStream();
            temp.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@prodname", txtPName.Text);
            ht.Add("@price", txtPrice.Text);
            ht.Add("@cat", Convert.ToInt32(cmbCategory.SelectedValue));
          //  ht.Add("@cat", Convert.ToInt32(cmbCategory.SelectedValue));
            ht.Add("@img", imageByteArray);

            if(MainClass.SQL(qry,ht) > 0)
            {
                MessageBox.Show("Saved Successfully!");
                    this.Dispose();
                id = 0;
                cID = 0;
                txtPName.Text = "";
                txtPrice.Text = "";
                cmbCategory.SelectedIndex = 0;
                cmbCategory.SelectedIndex = -1;
                txtImage.Image = JOLLIBURGER.Properties.Resources.logo;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ForUpdateLoadData()
        {
            string qry = @"SELECT * FROM tblproducts WHERE prodId = " + id + "";
            MySqlCommand cmd = new MySqlCommand(qry, MainClass.cn); 
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if(dt.Rows.Count > 0)
            {
                txtPName.Text = dt.Rows[0]["pname"].ToString();
                txtPrice.Text = dt.Rows[0]["pprice"].ToString();
               // cmbCategory.Text = dt.Rows[0]["categoryname"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["pimage"]);
                byte[] imageByteArray = imageArray;
                txtImage.Image = Image.FromStream(new MemoryStream(imageArray));
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtPName.Text = "";
            txtPrice.Text = "";
            cmbCategory.Text = "";
         
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a valid price.");
                txtPrice.Text = txtPrice.Text.Remove(txtPrice.Text.Length - 1);
            }
        }
    }
}
