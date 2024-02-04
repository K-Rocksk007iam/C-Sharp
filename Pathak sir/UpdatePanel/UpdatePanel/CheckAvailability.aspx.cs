using System;
using System.Data;
using System.Data.SqlClient;

namespace UpdatePanel
{
    public partial class CheckAvailability : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CheckUserNameAvailability(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtun.Text))
            {
                using (SqlConnection conn = new SqlConnection("Data Source=CDACLAB-92\\SQLEXPRESS;Database=DatabaseSample;Persist Security Info=True;trusted_connection=no;User ID=sa; Password=123456"))
                {
                    conn.Open();

                    string checkUsernameQuery = "SELECT COUNT(*) FROM Table_Sample WHERE UserName = @UserName";

                    using (SqlCommand cmdCheckUsername = new SqlCommand(checkUsernameQuery, conn))
                    {
                        // Use parameterized query to prevent SQL injection
                        cmdCheckUsername.Parameters.AddWithValue("@UserName", txtun.Text);

                        int userCount = (int)cmdCheckUsername.ExecuteScalar();

                        if (userCount > 0)
                        {
                            // Username already exists
                            checkun.Visible = true;
                            shwimg.ImageUrl = "Cancel.png";
                            lblmsg.Text = "Username already exists. Please choose a different one.";
                        }
                        else
                        {
                            // Username is available
                            checkun.Visible = true;
                            shwimg.ImageUrl = "Accepted.png";
                            lblmsg.Text = "Congratulations! Username is available to use";
                        }
                    }

                    // Load data into GridView after checking availability
                    string loadDataQuery = "SELECT * FROM Table_Sample";

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadDataQuery, conn))
                    {
                        DataSet dataSet = new DataSet();
                        sqlDataAdapter.Fill(dataSet);

                        GridView1.DataSource = dataSet.Tables[0];
                        GridView1.DataBind();
                    }
                }
            }
        }
    }
}
