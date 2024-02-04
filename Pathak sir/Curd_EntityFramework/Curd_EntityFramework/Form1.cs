using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Curd_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestDbEntities obj = new TestDbEntities();

            LoginTable newItem = new LoginTable();
            newItem.username = textBox1.Text;
            newItem.pwd = textBox2.Text;

            obj.LoginTables.Add(newItem);
            obj.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestDbEntities obj = new TestDbEntities();

            var q = from a in obj.LoginTables
                    select a;
            dataGridView1.DataSource = q.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestDbEntities obj = new TestDbEntities();

            var itemToDelete = obj.LoginTables.FirstOrDefault(a => a.username.Contains(textBox3.Text));

            if (itemToDelete != null)
            {
                obj.LoginTables.Remove(itemToDelete);
                obj.SaveChanges();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TestDbEntities obj = new TestDbEntities();
            var values = from p in obj.LoginTables
                         where p.username.StartsWith(textBox4.Text)
                         select p;
            dataGridView1.DataSource = values.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            TestDbEntities obj = new TestDbEntities();

            var itemToUpdate = obj.LoginTables.FirstOrDefault(a => a.username.Contains(textBox5.Text));

            if (itemToUpdate != null)
            {
                itemToUpdate.username = textBox7.Text;
                obj.SaveChanges();
            }
        }
    }
}
