using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = Convert.ToInt32(Console.ReadLine());
            int minute = Convert.ToInt32(Console.ReadLine());
            int seconds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter choice :");
            Console.WriteLine("1.minu to sec :");
            Console.WriteLine("2.minu to hours :");
            Console.WriteLine("3.second to minute :"); 
            Console.WriteLine("4.second to hours :");
            Console.WriteLine("5.hours to minute :");
            Console.WriteLine("6.hours to sec :");
            int ch=Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine(minute*60);
                    break;

                    case 2:
                    Console.WriteLine(seconds*60);
                    break;

                case 3:
                    Console.WriteLine(seconds /60);
                    break;

                case 4:
                    Console.WriteLine(seconds / 360);
                    break;

                case 5:
                    Console.WriteLine(hours * 60);
                    break;

                case 6:
                    Console.WriteLine(hours * 360);
                    break;

                    default:
                    Console.WriteLine("invalid");
                    break;
            }
            Console.ReadLine(); 

        }
       
    }
}
