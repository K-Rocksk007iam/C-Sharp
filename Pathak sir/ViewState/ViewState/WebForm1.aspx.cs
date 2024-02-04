using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(ViewState["MyVal"]))){
                TextBox2.Text = ViewState["MyVal"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["MyVal"]=TextBox1.Text;
            Response.Redirect("Second.aspx");
        }
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
}