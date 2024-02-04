using System;


namespace InheritanceDemo
{
    internal class Circle:Shape
    {
        public static void area(int radius)
        {
            Console.WriteLine(3.14*radius*radius);
        }
    }
}
