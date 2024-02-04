﻿using System;
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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void deleteTheRecord_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=CDACLAB-92\\SQLEXPRESS;Database=DatabaseSample;Persist Security Info=True;User ID=sa; Password=123456");

            try
            {
                SqlCommand cmd = new SqlCommand("deletevalues", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uname", textBox1.Text);
                cmd.Parameters.AddWithValue("@pwd", textBox2.Text);
                cmd.Parameters.AddWithValue("@id", -1);
                cmd.Parameters["@id"].Direction = ParameterDirection.Output;


                conn.Open();
                cmd.ExecuteNonQuery();
                int result = Convert.ToInt32(cmd.Parameters["@id"].Value);



                if (result == 1)
                {
                    MessageBox.Show("Delete successfully");
                }
                else
                {
                    MessageBox.Show("Record not found or deletion failed");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error he bhai");
            }
            finally
            {
                conn.Close();
            }
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Sample", conn);
            da.Fill(ds);
        }
    }
}
