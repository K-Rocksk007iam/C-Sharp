using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RTOMasterPage
{
    public partial class LoginMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=CDACLAB-92\\SQLEXPRESS;Database=DatabaseSample;Persist Security Info=True;trusted_connection=no;User ID=sa; Password=123456");
           DataSet dataSet = new DataSet();
          SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Table_Sample",conn);
          sqlDataAdapter.Fill(dataSet);
          
           
            GridView1.DataSource=dataSet.Tables[0];
            GridView1.DataBind();
        }
    }
}