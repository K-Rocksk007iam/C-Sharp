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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SqlConnection connec = new SqlConnection();
            connec.ConnectionString = "Data Source=CDACLAB-92\\SQLEXPRESS;Database=DatabaseSample;Persist Security Info=True;User ID=sa; Password=123456";
           // string query1 = "select count(UserName) from Table_Sample where UserName='" + txtNewUserName.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter("selectData", connec);
            da.SelectCommand.CommandType= CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@uname", txtNewUserName.Text);
            da.SelectCommand.Parameters.AddWithValue("@pwd", txtNewPassword.Text);
            da.Fill(dataSet);
            int retVal = Convert.ToInt32(dataSet.Tables[0].Rows[0][0]);
            if (retVal == 0)
            {
                String query2 = "insert into Table_Sample values('" + txtNewUserName.Text + "','" + txtNewPassword.Text + "')";
                SqlCommand cmd = new SqlCommand("insertValues", connec);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UName", txtNewUserName.Text);
                cmd.Parameters.AddWithValue("@Pass", txtNewPassword.Text);
                cmd.Parameters.AddWithValue("@id", -1);
                cmd.Parameters["@id"].Direction = ParameterDirection.Output;
                

                connec.Open();
                cmd.ExecuteNonQuery();
                int x = (int)cmd.Parameters["@id"].Value;
                connec.Close();
                if(x == 1)
                {
                    MessageBox.Show("New registration success");
                }
                else
                {
                    MessageBox.Show("Not register");
                }
                MessageBox.Show("Success sign Up");
                this.Hide();
                NewRegistration obj = new NewRegistration();
                obj.Show();
            }
            else
            {
                MessageBox.Show("this username is already registred");
            }

            
            
        }
    }
}
