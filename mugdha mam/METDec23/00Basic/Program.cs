
using System;

namespace _00Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DataTypes
            //int i = 10;
            //Int32 y = 20;
            //System.Int32 x = 30;
            //short s = 2;
            //long lng = 2345678;
            //char ch = 'a';
            //double d = 23.33;
            //bool b = true;
            //string str = "Hello";
            ////String str = new String("Hello");

            //Console.WriteLine(i+" "+b+" "+str); 
            #endregion

            #region ildasm 
            // ildasm command to see IL code.

            //int n1 = 100;

            //string str = "Hi";

            //double d = 24.33; 
            #endregion

            #region methods 
            //SayHi();
            //Program.SayHi();

            //string greet = SayHello("Hugh Jackman");
            //Console.WriteLine(greet); 
            #endregion

            Myclass myclass = new Myclass();
            myclass.SayHi();

            Console.ReadLine();
        }

        static void SayHi()
        {
            Console.WriteLine("Hi");
        }
        static string SayHello(string nm)
        {
            return "Hello " + nm;
        }
    }

    public class Myclass
    {
        public Myclass()
        {
            
        }
        public void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}
