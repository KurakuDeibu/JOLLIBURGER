using System;
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
            string qry = "SELECT * FROM tblcategory";
            MySqlCommand cmd = new MySqlCommand(qry, MainClass.cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0) 
            {
                foreach (DataRow row in dt.Rows)
                {
                    //ButtonMode.btnCategories b = new btn();
                    //b.FillColor = Color.FromArgb(0, 0, 0);
                    //b.Size = new Size(132, 45);
                    //b.ButtonMode = BtnMode.Radiobutton;
                    //b.Text = row["categoryanem"].ToString();

                    //CategoryPanel.Controls.Add(b);

                }
            }

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
