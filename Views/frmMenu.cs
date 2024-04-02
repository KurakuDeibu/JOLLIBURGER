using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace JOLLIBURGER.Views
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void showPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddCategory()
        {
            string qry = "SELECT * FROM tblcategory ORDER BY categoryid ASC";
            MySqlCommand cmd = new MySqlCommand(qry, MainClass.cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0) 
            {
                foreach (DataRow row in dt.Rows)
                {
                    Button b = new Button();
                    b.BackColor = Color.White;
                    b.ForeColor = Color.DarkOrange;
                    b.Size = new Size(80, 45);
                   
                        // b.Size = ButtonBase;
                    //b.ButtonMode = ButtonState.Enum.ButtonMode.RadioButton;
                    
                    b.Text = row["categoryname"].ToString();
                    CategoryPanel.Controls.Add(b);

                }
            }

        }

        private void AddItems(string id, string name, string cat, string price, Image pimage)
        {
            var w = new ucProducts()
            {
                PName = Name,
                pprice = price,
                pcategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(id)
            };
            ProductPanel.Controls.Add(w);
            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProducts)ss;

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgv_id"].Value) == wdg.id)
                    {
                        item.Cells["dgv_qty"].Value = int.Parse(item.Cells["dgv_qty"].ToString()) + 1;
                        item.Cells["dgv_amt"].Value = int.Parse(item.Cells["dgv_qty"].ToString()) + 1;
                        double.Parse(item.Cells["dgv_price"].ToString());

                    }
                    dataGridView1.Rows.Add(new object[] { 0, wdg.id, wdg.PName, 1, wdg.pprice, wdg.pprice });
                }
            };
        }

        private void LoadProducts()
        {
            string qry = "SELECT * FROM tblproducts INNER JOIN tblcategory on categoryid = CategoryID";
            MySqlCommand cmd = new MySqlCommand(qry, MainClass.cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imageArray = (byte[])item["pimage"];
                byte[] imagebytearray = imageArray;

                AddItems(item["prodId"].ToString(), item["pname"].ToString(), item["categoryname"].ToString(),
                    item["pprice"].ToString(), Image.FromStream(new MemoryStream(imageArray)));
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            //LoadProducts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            
            if (MessageBox.Show("Exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm.Show();
                this.Hide();
            }
        }
    }
}
