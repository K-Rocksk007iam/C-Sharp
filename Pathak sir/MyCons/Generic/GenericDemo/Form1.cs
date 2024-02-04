using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericDemo
{
    public partial class Form1 : Form
    {
       // List<int> numbers = new List<int>();
       //SortedList<int , string> keyValuePairs = new SortedList<int , string>();
       IDictionary<int, string> data = new Dictionary<int, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                // keyValuePairs.Add(Convert.ToInt32(textBox1.Text), textBox3.Text);
                data.Add(Convert.ToInt32(textBox1.Text), textBox3.Text);
            }
            catch(Exception ex)
            {   
                MessageBox.Show("bhonsle sir error aagya pehle Integer dalo phir string or duplicate dala he");
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            //foreach (KeyValuePair<int, string> kvp in keyValuePairs)
            //{
               
            //    textBox2.Text+=kvp.Key +" "+ kvp.Value +Environment.NewLine;
                
            //}

           foreach(var item in data)
            {
                textBox2.Text+=item.Key+" "+item.Value+Environment.NewLine;
            }
        }

        
    }
}
