using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesDemo
{
    public partial class CookieSend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["val"].Value = TextBox1.Text;

            Response.Redirect("CookieReceive.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie userData = new HttpCookie("val");
            userData["val"]=TextBox2.Text;
            userData.Expires = DateTime.Now.AddSeconds(20);
            Response.Cookies.Add(userData);
            Response.Redirect("CookieReceive.aspx");
        }

        
    }
}