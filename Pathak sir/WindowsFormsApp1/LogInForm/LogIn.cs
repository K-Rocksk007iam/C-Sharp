using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LogInForm
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=CDACLAB-92\\SQLEXPRESS;Database=DatabaseSample;Persist Security Info=True;User ID=sa; Password=123456";
           // string query = "select count(UserName)from Table_Sample where UserName='"+txtUserName.Text+"' and Password='"+txtPassword.Text+"'";
            

            SqlDataAdapter adapter = new SqlDataAdapter("selectData", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@uname", txtUserName.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@pwd", txtPassword.Text);
            adapter.Fill(ds);

            int retVal = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            if(retVal == 1)
            {
                // MessageBox.Show("Success");
                Message obj = new Message();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewRegistration obj = new NewRegistration();
            obj.Show();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void deleteValues_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete obj = new Delete();
            obj.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upadte obj = new Upadte();
            obj.Show();
        }
    }
}
