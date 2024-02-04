using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj = new B();
            obj.Addi();
        }
    }
    public class A
    {
        public void Addi()
        {
            System.Console.WriteLine("A");
        }
    }
    public class B:A
    {
        public void Addi()
        {
            System.Console.WriteLine("B");
        }
    }
    public class C:B
    {
        public void Addi()
        {
            System.Console.WriteLine("C");
        }
    }
}
