using JOLLIBURGER.Model;
using JOLLIBURGER.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOLLIBURGER
{
    public partial class frmMainDashboard : Form
    {
        public frmMainDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public void AddControls(Form f)
        {
            main_Panel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            main_Panel.Controls.Add(f);
            f.Show();
        }

        private void btnMainCategory_Click(object sender, EventArgs e)
        {
            // To show form inside the main form
            //frmCategory frm = new frmCategory();
            //frm.TopLevel = false;
            //main_Panel.Controls.Add(frm);
            //frm.BringToFront();
            //frm.Show();

            AddControls(new frmCategory());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to log out?" , "Logout" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
            }
        }

        private void btnMainProducts_Click(object sender, EventArgs e)
        {
            //frmProduct frm = new frmProduct();
            //frm.TopLevel = false;
            //main_Panel.Controls.Add(frm);
            //frm.BringToFront();
            //frm.Show();

            AddControls(new frmProduct());

        }
    }
}
