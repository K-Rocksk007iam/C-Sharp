using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 x;
            x = Convert.ToInt32(Console.ReadLine());
            x *= x;
            Console.WriteLine(x);
           

            String str=Console.ReadLine();
           
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToUpper()+" Suryawanshi");
            Console.ReadLine();
        }
    }
}
