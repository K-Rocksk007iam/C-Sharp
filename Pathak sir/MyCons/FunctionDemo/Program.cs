using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("Before change {0}{1}", num1, num2);
            obj.fun(ref num1, ref num2);
            Console.WriteLine("after change {0}{1}",num1,num2);
            Console.ReadLine();
        }

        public void fun(ref int x,ref int y)
        {
            x++;
            y++;
            Console.WriteLine("x:"+x+":"+y);
        }
    }
}
