using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.net
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void Submit_Click(object sender, EventArgs e)
        {
            string name =TextBox1.Text;
            string address = TextBox2.Text;
            string email = TextBox3.Text;
            string number = TextBox4.Text;
            string gender = RadioButtonList1.Text;
            string scolarship = CheckBoxList1.Text;
            string course=DropDownList1.Text;


            TextBox5.Text = name+Environment.NewLine+address+ Environment.NewLine + email + Environment.NewLine + number + Environment.NewLine + gender + Environment.NewLine + (scolarship)+ Environment.NewLine + course;

        }

        
    }
}