using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileIOWEB
{
    public partial class FileIO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/path").ToString();
            path = path + "\\MyFile.txt";

            FileStream fileStream = new FileStream(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine(TextBox1.Text);
            writer.Close();
            fileStream.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/path").ToString();
            path = path + "\\MyFile.txt";

            FileStream fileStream = new FileStream(path, FileMode.Open);
            StreamReader writer = new StreamReader(fileStream);
            TextBox2.Text = "";
            TextBox2.Text=TextBox2.Text+writer.ReadToEnd(); 
            writer.Close();
            fileStream.Close();

        }
    }
}