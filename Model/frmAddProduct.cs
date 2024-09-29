using JOLLIBURGER.Views;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JOLLIBURGER.Model
{
    public partial class frmAddProduct : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        DBConnection DBcon = new DBConnection();

        public frmAddProduct()
        {   
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());
            autoID();
        }



        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|*.png; *.jpg";
            ofd.Multiselect = false;
            ofd.Title = "Select Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImage.BackgroundImage = Image.FromFile(ofd.FileName);
                ofd.FileName = ofd.FileName;
                btnSave.Focus();
            }
            else
            {
                MessageBox.Show("Please select an image.", "No Image Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void autoID()
        {
            try
            {
                string sql = "select MAX(prodID) from tblproducts";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cn.Open();

                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                    txtID.Text = "P-001";
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 3));
                    intval++;
                    txtID.Text = String.Format("P-{0:000}", intval);
                }

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(cmbCategory.Text) || txtImage.BackgroundImage == null || string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show("All fields are required, including the image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


                if (MessageBox.Show("Save this record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MemoryStream mstream = new MemoryStream();
                    txtImage.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrimage = mstream.GetBuffer();

                    cn.Open();
                    MySqlCommand cm = new MySqlCommand("insert into tblproducts(prodID, name, price, category,status, image) values (@id, @name, @price, @category, @status, @image)", cn);

                    cm.Parameters.AddWithValue("@id", txtID.Text);
                    cm.Parameters.AddWithValue("@name", txtName.Text);
                    cm.Parameters.AddWithValue("@price", Convert.ToDouble(txtPrice.Text));
                    cm.Parameters.AddWithValue("@category", cmbCategory.Text);
                    cm.Parameters.AddWithValue("@status", cmbStatus.Text);
                    cm.Parameters.AddWithValue("@image", arrimage);

                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Record has been successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();
                    autoID();
                    this.Dispose();
                }

                frmProduct frm = new frmProduct();
                frm.LoadRecords();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
 
         

        public void LoadCategory() {

                cmbCategory.Items.Clear(); 
                cn.Open(); 
                MySqlCommand cm = new MySqlCommand("select * from tblcategory", cn); 
                MySqlDataReader dr = cm.ExecuteReader(); 

                while (dr.Read()) { 
                    cmbCategory.Items.Add(dr["categoryname"].ToString()); 
                }
                dr.Close(); 
                cn.Close(); 
            }


        public void Clear()
        {
            txtName.Clear();
            txtPrice.Clear();   
            cmbCategory.Text = "";
            cmbStatus.Text = "";
            txtImage.Image = null;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtName.Focus();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.LoadRecords();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   
            frmAddCategory frm = new frmAddCategory();
            frm.ShowDialog();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "[^0-9.]"))
            //{
            //    MessageBox.Show("Please enter a valid price.");
            //    txtPrice.Text = txtPrice.Text.Remove(txtPrice.Text.Length - 1);
            //}
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Update this product?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MemoryStream mstream = new MemoryStream();
                    txtImage.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrimage = mstream.GetBuffer();

                    cn.Open();
                    MySqlCommand cm = new MySqlCommand("UPDATE tblproducts SET name=@name, price=@price, category=@category, image=@image, status=@status WHERE prodID=@id", cn);

                    cm.Parameters.AddWithValue("@id", txtID.Text);
                    cm.Parameters.AddWithValue("@name", txtName.Text);
                    cm.Parameters.AddWithValue("@price", Convert.ToDouble(txtPrice.Text));
                    cm.Parameters.AddWithValue("@category", cmbCategory.Text);
                    cm.Parameters.AddWithValue("@image", arrimage);
                    cm.Parameters.AddWithValue("@status", cmbStatus.Text);

                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Product has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();
                    autoID();
                    frmProduct frm = new frmProduct();
                    frm.LoadRecords();

                }
                this.Dispose();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('.')>-1))
            {
                e.Handled= true;
            } 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtImage_Click(object sender, EventArgs e)
        {

        }
    }
}
