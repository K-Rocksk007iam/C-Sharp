using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string fun1(string s)
        {

            return s + " vadapav vadapav";
            #region comments
            //this is  method which is returninng the String
            //this is  method which is returninng the String
            //this is  method which is returninng the String
            //this is  method which is returninng the String
            //this is  method which is returninng the String
            //this is method which is returninng the String
            //this is method which is returninng the String
            #endregion

            if(s != "hey")
            { int i = 0;
                do
                {
                    System.Console.WriteLine(s + " kuch bhi");
                    i++;
                }
                while (i < 10);
            }


        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            String s = "kya bolti public";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(fun1(s));
            System.Console.WriteLine("chalo chale nile gagan ko!!!!!");
            Console.ReadLine();
        }
    }
}
