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
            AddControls(new frmAccounts());

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
            frmCategory frm = new frmCategory();
            frm.TopLevel = false;
            main_Panel.Controls.Add(frm);

            frm.BringToFront();
            frm.Show();


            //AddControls(new frmCategory());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMainDashboard_Load(object sender, EventArgs e)
        {
             
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            string lbl = lbl_username.Text; 
            if (MessageBox.Show("Login as Cashier?", "Cashier Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                frmMenu frmLogin = new frmMenu();
                frmLogin.label7.Text = lbl;
                frmLogin.Show();
                
                this.Hide();
            }
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
            
        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Minimized ? FormWindowState.Normal : FormWindowState.Minimized;
        }


        private bool mouseDown;
        private Point lastLocation;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategory());

        }
    }
}
