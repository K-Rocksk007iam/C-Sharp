using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursToMinute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hours ");
            int hours=Convert.ToInt32(Console.ReadLine());
            int minutes=hours*60;
            int seconds=minutes*60;
            Console.WriteLine("minutes Are : "+ minutes+"seconds Are :"+seconds);
            Console.ReadLine();
        }
    }
}
