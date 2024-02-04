using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ClassDemo
{
    public class CMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public virtual int Mult(int x, int y) 
        {
            return x * y;
        }

        public virtual void SayHi()
        {
            Console.WriteLine("Hi");
        }
        public virtual void SayBye()
        {
            Console.WriteLine("Bye");
        }
    }
    public class AdvanceMath : CMath
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi There!");
        }
        public override int Mult (int x, int y)
        {
            return x * y * 100;
        }
        public new int Add(int x, int y)
        { 
            return x + y + 100;
        }
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        public int Square(int x)
        {
            return x * x;
        }
    }
   
}
