using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LogInForm
{
    public partial class NewRegistration : Form
    {
        public NewRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            SqlConnection conn = new SqlConnection("Data Source=CDACLAB-92\\SQLEXPRESS;Database=DatabaseSample;Persist Security Info=True;User ID=sa; Password=123456");
            SqlCommand cmd = new SqlCommand("insertValues", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UName",textBox1.Text );
            cmd.Parameters.AddWithValue("@Pass", textBox2.Text);
            cmd.Parameters.AddWithValue("@id", -1);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Sample", conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }
    }
}
