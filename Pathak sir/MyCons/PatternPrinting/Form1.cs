using System;

using System.Windows.Forms;

namespace PatternPrinting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (Row.Text != null || Column.Text != null)
                {
                    textBox3.Text = "";

                    int column = Convert.ToInt32(Column.Text);
                    for (int i = 0; i < column; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            textBox3.Text = textBox3.Text + "* ";
                        }
                        textBox3.Text = textBox3.Text + Environment.NewLine;
                    }
                }
                else
                {
                    textBox3.Text = "Invalid";
                }
            }
          
        }
    }

