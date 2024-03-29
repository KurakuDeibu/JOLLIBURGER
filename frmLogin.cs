using Microsoft.Win32;
using MySql.Data.MySqlClient;
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
    public partial class frmLogin : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();
        MainClass hc = new MainClass(); // Call hash

        public frmLogin()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());
            txtBoxUser.Multiline = false;
            txtBoxPass.Multiline = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmRegister form = new frmRegister();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = "", _role = "", _name = "";

            if (txtBoxPass.Text == string.Empty || txtBoxUser.Text == string.Empty)
            {
                MessageBox.Show("Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {


                bool found = false;
                cn.Open();
                cm = new MySqlCommand("SELECT * FROM tblaccounts WHERE username = @username and password =@password", cn);
                cm.Parameters.AddWithValue("@username", txtBoxUser.Text);
                cm.Parameters.AddWithValue("@password", hc.PassHash(txtBoxPass.Text));
                dr = cm.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _role = dr["role"].ToString();
                    _name = dr["name"].ToString(); // to show name on welcome/dashboard

                }
                else
                {
                    found = false;
                }

                dr.Close();
                cn.Close();

                if (found == true)
                {
                    if (_role == "Admin")
                    {
                        MessageBox.Show("Welcome " + _name + "!", "Redirecting to Admin Dashboard...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxPass.Clear();
                        txtBoxUser.Clear();
                        this.Hide();
                        frmMainDashboard frm = new frmMainDashboard();
                        frm.ShowDialog();
                    }
                    else if (_role == "Cashier")
                    {
                        MessageBox.Show("Welcome " + _name + "!", "Redirecting to Cashier Menu...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxPass.Clear();
                        txtBoxUser.Clear();
                        this.Hide();
                        frmMainDashboard frm = new frmMainDashboard(); // go to burger shop form -
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome!" + _name + "!", "Redirecting to Menu...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxPass.Clear();
                        txtBoxUser.Clear();
                        this.Hide();
                        frmMainDashboard frm = new frmMainDashboard(); // go to customer ordering form -
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxPass.Text = "";
            txtBoxUser.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtBoxPass.PasswordChar = '\0';
            }
            else
            {
                txtBoxPass.PasswordChar = '•';
            }
        }
    }
}
