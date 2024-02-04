using System;

namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleAccounts simpleAccounts = new SimpleAccounts();
            simpleAccounts.fun1();

            PartialAccounts partialAccounts = new PartialAccounts();
            partialAccounts.fun1();

            SealedAccounts sealedAccounts = new SealedAccounts();
            sealedAccounts.fun1();

            StaticAccounts.fun1();

            ChildAbstractAccounts childAbstractAccounts = new ChildAbstractAccounts();
            childAbstractAccounts.fun1();

          

            Console.ReadLine();
           
        }
    }

    public class SimpleAccounts
    {
        public void fun1()
        {
            Console.WriteLine("From SimpleAccounts class");
        }

    }
    abstract class ParentAbstractAccounts
    {
        
        public void fun1() { }
        
    }

     class ChildAbstractAccounts:ParentAbstractAccounts
    {
        public void fun1()
        {
            Console.WriteLine("From ChildAbstractAccounts class");
        }
    }

   partial class PartialAccounts

    {
        public void fun1()
        {
           
            Console.WriteLine("From PartialAccounts class");
        }
    }

 sealed class SealedAccounts
    {
        public void fun1()
        {
            Console.WriteLine("From SealedAccounts class");
        }
    }

    static class StaticAccounts
    {
        public static void fun1()
        {
            Console.WriteLine("From StaticAccounts class");
        }
    }
}
