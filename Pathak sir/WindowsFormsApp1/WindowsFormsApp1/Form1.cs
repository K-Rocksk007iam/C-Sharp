using System;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CDACLAB-92\\SQLEXPRESS;Database=TestDb;Persist Security Info=True;User ID=sa; Password=123456");
            String query = "insert into Login_Tab values('" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
          con.Close();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Login_Tab", con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
