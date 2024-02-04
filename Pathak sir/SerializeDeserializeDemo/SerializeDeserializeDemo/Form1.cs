using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializeDeserializeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        public void button1_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("C:\\Users\\CDAC\\Downloads\\.NET\\Pathak sir\\SerializeDeserializeDemo\\SerializeDeserializeDemo\\MyTXT\\serialized.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s2 = new Student(Convert.ToInt32(textBox1.Text),textBox2.Text);
            
            formatter.Serialize(fileStream, s2);
            MessageBox.Show("file Serialize");
            fileStream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("C:\\Users\\CDAC\\Downloads\\.NET\\Pathak sir\\SerializeDeserializeDemo\\SerializeDeserializeDemo\\MyTXT\\serialized.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = (Student)formatter.Deserialize(fileStream);
            
            textBox3.Text = s.sendRoll() + " " + s.sendName();
            fileStream.Close();
            MessageBox.Show("file Decerialize");
        }
    }
}
