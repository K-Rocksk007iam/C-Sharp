using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTO_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RTOappEntities obj = new RTOappEntities();
            var values = from p in obj.UserProfiles
                         select new
                         {
                             id = p.Id,
                             name = p.Name,
                             password = p.Password,
                             num=p.M_Number,
                             add=p.Address,
                         };
            dataGridView1.DataSource = values.ToList();
        }
    }
}
