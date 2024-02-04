using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionDemo
{
    public partial class SessionStart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName=TextBox1.Text;
            string password=TextBox5.Text;
            string val = "";
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=CDACLAB-92\\SQLEXPRESS;Database=DatabaseSample;Persist Security Info=True;trusted_connection=no;User ID=sa; Password=123456";

            if (userName != string.Empty && userName != null && userName != "")
            {
                
                string query = "select Username from Table_Sample where Username='" + userName + "' and Password='" + password + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(ds);
                val = ds.Tables[0].Rows[0][0].ToString();
            }
            if(val!="" && val != string.Empty)
            {
                Session["user"] = val;
                Response.Redirect("SessionCheck.aspx");
            }

           
            

        
        }
    }
}