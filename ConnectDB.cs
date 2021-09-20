using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLiTHPT
{
    class ConnectDB
    {
        SqlConnection cn = new SqlConnection();
        static public String getconnect()
        {
            return (@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=TruongTHPT;Integrated Security=True");
        }
    }
}
