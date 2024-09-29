using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOLLIBURGER
{
    internal class DBConnection
    {
        public string str_user, str_password, str_role;
        public string MyConnection() {

            //string con = "Data Source=ASPIRE3\\SQLEXPRESS; Initial Catalog=JOLLI_DB;Persist Security Info=True;";
            //string con = @"Data Source=ASPIRE3\SQLEXPRESS;Initial Catalog=JOLLI_DB;Integrated Security=True";

            string con = "server=localhost;user id=root;password=;database=jolliburger_db"; //DBConnection - jollidb = name of DB
            return con;
        }
    }
}
