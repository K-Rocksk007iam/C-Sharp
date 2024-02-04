using System;


namespace InheritanceDemo
{
    internal class Shape
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter values");
            
            

            Console.WriteLine("Enter values for circle");
            y = Convert.ToInt32(Console.ReadLine());
            Circle.area(y);
            Console.WriteLine("Enter values for Square");
            x = Convert.ToInt32(Console.ReadLine());
            Square.area(x);
            Console.WriteLine("Enter values for Rectangle");
            y = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());
            Rectangle.area(y, x);

            Console.ReadLine();
        }
    }
}
