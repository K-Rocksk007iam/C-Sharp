using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 m1, m2, m3;
            Console.WriteLine("Enter marks of three subjects");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            

            double percentage= (m1 + m2 + m3) / 3;
            if (percentage >= 32)
            {
                if (percentage >= 60 && percentage <= 100)
                {
                    Console.WriteLine("first grade");
                }
                if (percentage >= 55 && percentage <= 59)
                {
                    Console.WriteLine("second grade");
                }
                if (percentage >= 33 && percentage <= 54)
                {
                    Console.WriteLine("Third grade");
                }
                Console.WriteLine(percentage);
            }
            else
            {
                Console.WriteLine("fail");
            }
            Console.ReadLine(); 
        }
    }
}
