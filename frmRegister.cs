using Microsoft.Win32;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class frmRegister : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();

        public frmRegister()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());
            txtBoxUser.Multiline = false;
            txtBoxPass.Multiline = false;
            txtConfP.Multiline = false;
            txtName.Multiline = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxUser.Text = "";
            txtName.Text = "";
            txtBoxPass.Text = "";
            txtConfP.Text = "";
            cmbRole.Text = "";
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtBoxPass.PasswordChar = '\0';
                txtConfP.PasswordChar = '\0';
            }
            else
            {
                txtBoxPass.PasswordChar = '•';
                txtConfP.PasswordChar = '•';


            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfP.Text == string.Empty || txtBoxPass.Text == string.Empty || txtBoxUser.Text == string.Empty || txtName.Text == string.Empty)
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxPass.Text != txtConfP.Text)
                {
                    MessageBox.Show("Password does not match!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbRole.Text == string.Empty)
                {
                    MessageBox.Show("Please select a user role.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbRole.Focus();
                    return;
                }

                cn.Open();
                cm = new MySqlCommand("SELECT * FROM tblaccounts WHERE username='" + txtBoxUser.Text + "'", cn);
                dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Username already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cn.Close();
                }
                else
                {
                    dr.Close();
                    cm = new MySqlCommand("INSERT INTO tblaccounts (username, password, role, name) VALUES (@username, @password, @role, @name)", cn);
                    cm.Parameters.AddWithValue("username", txtBoxUser.Text);
                    cm.Parameters.AddWithValue("password", txtBoxPass.Text);//hc.PassHash(txtBoxPass.Text));
                    cm.Parameters.AddWithValue("@role", cmbRole.Text);
                    cm.Parameters.AddWithValue("@name", txtName.Text);

                    cm.ExecuteNonQuery();
                    MessageBox.Show("Successfully created, Please login now.", "Registered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Exception Error: ", "Error" + ex.Message);
            }

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
