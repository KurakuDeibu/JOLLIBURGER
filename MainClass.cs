using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace JOLLIBURGER
{
    internal class MainClass
    {
        // static readonly string con_string = "server=localhost;user id=root; password=;database=jollidb";
        public static readonly string con_string = "server=localhost;user id=root;password=;database=jollidb";
        public static MySqlConnection cn = new MySqlConnection(con_string);

        //for loading data from db
        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
          // gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);

            try
            {
                MySqlCommand cmd = new MySqlCommand(qry, cn);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                cn.Close();
            }
        }

        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand(qry, cn);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value.ToString());
                }
                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                res = cmd.ExecuteNonQuery();
                if (cn.State == ConnectionState.Open) { cn.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
            return res;
        }
        //for cb fill

        public static void CBFILL(string qry, ComboBox cb)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(qry, cn);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "name"; // name
                cb.ValueMember = "id"; //id
                cb.SelectedIndex = -1;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public string PassHash(string data)
        {
            SHA256 sha = SHA256.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder returnVal = new StringBuilder();

            for (int i = 0; i < hashdata.Length; i++)
            {
                returnVal.Append(hashdata[i].ToString());
            }
            return returnVal.ToString();

        }

        public static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }
    }
}

