using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RTO_App
{
    public class Connect
    {
        public String connectStr()
        {
            return "Data Source=CDACLAB-92\\SQLEXPRESS;Database=RTO-App;Persist Security Info=True;trusted_connection=no;User ID=sa; Password=123456";
        }

        public SqlConnection connectionObj()
        {
            SqlConnection conn = new SqlConnection(connectStr());
            return conn;
        }
        //public Boolean connectionStatus(SqlConnection obj)
        //{
        //    if (obj.State == "open")
        //    {
        //        return true;
        //    }
        //    else
            
        //        return false;
            
        //}
    }
}