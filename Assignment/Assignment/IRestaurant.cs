using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal interface IRestaurant
    {
        public void takeOrder();
        public void preparingFood();

        public void foodServed();
        public void printBill();

    }
}
