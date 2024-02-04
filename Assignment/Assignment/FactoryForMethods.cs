using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FactoryForMethods
    {
        FactoryForFood factoryForFood = new FactoryForFood();
        public void factoryProcessForVeg()
        {
            Veg veg = new Veg();
            FactoryForFood fsveg = new FactoryForFood();
            veg.takeOrder();
            System.Console.WriteLine("1.panner \t 180rs \n2.pulav \t 250rs \n3.dal rice \t 130rs");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            factoryForFood.factoryMethod(choice);
           
            veg.preparingFood();
            veg.foodServed();
            veg.printBill();
          
                if (choice == 1)
                {
                    Console.WriteLine("1.panner \t 180rs");

                }
                else if (choice == 2)
                {
                    Console.WriteLine("2.pulav \t 250rs");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("3.dal rice \t 130rs");
                }

            
        }

        public void factoryProcessForNONVeg()
        {
            NonVeg nonVeg = new NonVeg();
            nonVeg.takeOrder();
            System.Console.WriteLine("1.Biryani \t 280rs \n2.tawa biryani \t 350rs \n3.mughlai biryani\t 330rs");
            int choice = Convert.ToInt32(Console.ReadLine());
            factoryForFood.factoryMethodNonVEG(choice);
            nonVeg.preparingFood();
            nonVeg.foodServed();
            nonVeg.printBill();

            if (choice == 1)
                {
                    Console.WriteLine("1.Biryani \t 280rs");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("2.tawa biryani \t 350rs");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("3.mughlai biryani");
                }

            
           
        }
       
       
    }
}
