using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionDemo
{
    public partial class SessionCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] !=null){
                Label1.Text="Welcome " + Session["user"].ToString();
            }
            else
            {
                Label1.Text = "Something went wrong";
                Response.Redirect("SessionStart.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
               Session.Clear();
                Session.Abandon();
            }
        }
    }
}