﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLiTHPT
{
    class ConnectDB
    {
        SqlConnection cn = new SqlConnection();
        static public String getconnect()
        {
          
            return (@"Data Source=DESKTOP-VPF0AQ3;Initial Catalog=TruongTHPT;Integrated Security=True");
            
        }
       
          
    }
}
