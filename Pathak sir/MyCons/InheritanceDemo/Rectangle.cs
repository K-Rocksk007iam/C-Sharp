using System;


namespace InheritanceDemo
{
    internal class Rectangle:Shape
    {
        public static void area(int length , int breadth)
        {
            Console.WriteLine(length*breadth);
        }
    }
}
