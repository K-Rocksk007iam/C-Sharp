using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\CDAC\Downloads\tp.jpg");
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
            pictureBox2.Image = default;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.BackColor = textBox3.BackColor;
            textBox3.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = textBox4.BackColor;
            textBox4.BackColor = Color.White;
        }
    }
}
