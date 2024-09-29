using JOLLIBURGER.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JOLLIBURGER.Views
{
    public partial class frmCustomer : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();

        public frmCustomer()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());
            autoID();
            LoadCustomer();
        }

        public void autoID()
        {
            try
            {
                string sql = "select MAX(customerid) from tblcustomer";
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cn.Open();

                var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                    txtID.Text = "C-001";
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 3));
                    intval++;
                    txtID.Text = String.Format("C-{0:000}", intval);
                }

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtCustname.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (MessageBox.Show("Save Customer?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();
                    MySqlCommand cm = new MySqlCommand("insert into tblcustomer(customerid, customername, phoneNo) values (@id, @name, @phone)", cn);

                    cm.Parameters.AddWithValue("@id", txtID.Text);
                    cm.Parameters.AddWithValue("@name", txtCustname.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);

                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Customer has been successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();
                    autoID();
                    LoadCustomer();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Clear()
        {
            txtCustname.Text = "";
            txtPhone.Text = "";

        }

        public void LoadCustomer()
        {
            try
            {

                cn.Open();
                dataGridView1.Rows.Clear();

                MySqlCommand cm = new MySqlCommand("select * from tblcustomer", cn);
                MySqlDataReader dr = cm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    i += 1;
                    i = dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["customerid"].Value = dr["customerid"].ToString();
                    dataGridView1.Rows[i].Cells["customername"].Value = dr["customername"].ToString();
                    dataGridView1.Rows[i].Cells["phoneNo"].Value = dr["phoneNo"].ToString();

                }

                dr.Close();
                cn.Close();

                //for (int k = 0; k < dataGridView1.Rows.Count - 1; k++)
                //{
                //    DataGridViewRow r = dataGridView1.Rows[k];
                //    r.Height = 30;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dataGridView1.Columns[e.ColumnIndex].Name;

         if (colname == "dgvDELETE")
            {
                if (MessageBox.Show("Delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("DELETE FROM tblcustomer WHERE customerid like @id", cn);
                    cm.Parameters.AddWithValue("@id", dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Customer has been successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomer();
                    autoID();
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
