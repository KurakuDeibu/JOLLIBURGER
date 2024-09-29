using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace JOLLIBURGER.Views
{
    public partial class frmReport : Form
    {
        MySqlConnection cn = new MySqlConnection();
        MySqlCommand cm = new MySqlCommand();
        MySqlDataReader dr;
        DBConnection DBcon = new DBConnection();
        
        public frmReport()
        {
            InitializeComponent();
            cn = new MySqlConnection(DBcon.MyConnection());

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 100;
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
          //  reportViewer1.LocalReport.DataSources.Clear();
          ////  reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Report", ($"SELECT * FROM tblproducts", "product")));
          //  reportViewer1.LocalReport.ReportPath = $"{Application.StartupPath}/Report1.rdlc";
          //  this.reportViewer1.RefreshReport();
        }

        public void LoadReport()
        {
            MessageBox.Show("Print Product Details?", "Product Report");

            cn.Open();
            cm = new MySqlCommand("SELECT * FROM tblproducts", cn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            frmReport frm = new frmReport();
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = "Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
            cn.Close();
        }
    }
}
