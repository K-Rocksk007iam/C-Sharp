using System;

using System.IO;

using System.Windows.Forms;

namespace FileIOStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("C:\\Users\\CDAC\\Downloads\\.NET\\Pathak sir\\txt\\file.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f);
            sw.WriteLine(textBox1.Text);
            sw.Close();
            f.Close();
            MessageBox.Show("FILE CREATED SUCCESSFULLY");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("C:\\Users\\CDAC\\Downloads\\.NET\\Pathak sir\\txt\\file.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);
            textBox2.Text = "";
            textBox2.Text =  sr.ReadToEnd();
            sr.Close();
            f.Close ();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("C:\\Users\\CDAC\\Downloads\\.NET\\Pathak sir\\txt\\file.txt", FileMode.Truncate);
            StreamReader sr = new StreamReader(f);
            MessageBox.Show("FILE TRUNCATED");
            sr.Close();
            f.Close();

        }
    }
}
