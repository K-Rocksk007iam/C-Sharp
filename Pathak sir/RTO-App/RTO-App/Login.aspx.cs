using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RTO_App
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name, UType;
            Connect connect = new Connect();
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connect.connectStr());
            SqlDataAdapter adapter = new SqlDataAdapter("SelectUserDetails",con);
            adapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@uname", TextBox1.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@pwd", TextBox2.Text);
            adapter.Fill(ds);

            if (ds.Tables.Count > 0)
            {
                name = ds.Tables[0].Rows[0][0].ToString();
                UType= ds.Tables[0].Rows[0][1].ToString();
                if (UType == "agent")
                {
                    Response.Redirect("Agent.aspx");
                }
                else if (UType == "RTO")
                {
                    Response.Redirect("RTO.aspx");
                }
                else if (UType == "Clerk")
                {
                    Response.Redirect("Clerk.aspx");
                }

            }
            else
            {

            }

        }
    }
}