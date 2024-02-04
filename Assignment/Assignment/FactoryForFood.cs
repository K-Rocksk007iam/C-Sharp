using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FactoryForFood
    {
        public void factoryMethod(int num)
        {
            if (num == 1)
            {
                Console.WriteLine("you selected paneer");

            }
            else if (num == 2)
            {
                Console.WriteLine("you selected pulav");
            }
            else if (num == 3)
            {
                Console.WriteLine("you selected dalRice");
            }
            else
            {
                Console.WriteLine("Not in VEG menu");
                
            }

        }

        public void factoryMethodNonVEG(int num)
        {
            if (num == 1)
            {
                Console.WriteLine("you selected Biryani");
            }
            else if (num == 2)
            {
                Console.WriteLine("you selected tawa biryani");
            }
            else if (num == 3)
            {
                Console.WriteLine("you selected mughlai biryani");
            }
            else
            {
                Console.WriteLine("Not in NON_VEG menu");
                
            }

        }
    }
}
