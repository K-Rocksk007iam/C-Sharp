namespace Assignment
{
    internal class Restaurant
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What you want for lunch :");
                Console.WriteLine("1:VEG 2:NON-VEG");
                int ch = Convert.ToInt32(Console.ReadLine());
                Logger logger = new Logger();
                
                FactoryForMethods fmeth = new FactoryForMethods();
                switch (ch)
                {
                    case 1:

                        fmeth.factoryProcessForVeg();
                     
                        logger.loggedIn();
                       
                        break;

                  case 2:
                        fmeth.factoryProcessForNONVeg();
                        
                        logger.loggedIn();

                        break;
                }
               
                Console.WriteLine("do you want to continue (Y/N)");
                String cho = Console.ReadLine();
                if (cho == "N" || cho=="n")
                {
                    break;
                }
            }
            

        }

      


    }


}