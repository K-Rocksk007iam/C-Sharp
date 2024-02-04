using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Veg : IRestaurant
    {
        public void foodServed()
        {
            Console.WriteLine("food is served");
        }

        public void preparingFood()
        {
            Console.WriteLine("food is prepared");
        }

        public void printBill()
        {
            Console.WriteLine("bill is printed");
        }

        public void takeOrder()
        {
            Console.WriteLine("taking the order");
        }
    }
}
