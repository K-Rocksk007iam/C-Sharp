using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDeserializeDemo
{
    [Serializable]
    public class Student
    {
       int rollNo;
       string name;

        public Student()
        {
        }

        public Student(int rollNo, string name)
        {
            this.rollNo = rollNo;
            this.name = name;
        }
        public int sendRoll()
        {
            return rollNo;
           
        }
        public String sendName()
        {
            
            return name;
        }


    }
   
}
