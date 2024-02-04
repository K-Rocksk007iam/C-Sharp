using System.Collections.Generic;

namespace InheritanceDemo
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the database :");
            Console.WriteLine("1:SQl 2:ORACLE");
            int ch = Convert.ToInt32(Console.ReadLine());
            do {
                switch (ch)
                {

                    case 1:
                        IDatabase db1 = new Sql();
                        Console.WriteLine("enter which operation to perform");
                        Console.WriteLine("1:insert 2:delete 3:update 4:deleteAll 5:updateAll");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            db1.insert();
                        }
                        else if (choice == 2)
                        {
                            db1.delete();
                        }
                        else if (choice == 3)
                        {
                            db1.update();
                        }
                        else if (choice == 4)
                        {
                            db1.deleteAll();
                        }
                        else if (choice == 5)
                        {
                            db1.updateAll();
                        }
                        else if (choice == 0)
                        {
                            Console.WriteLine("exit");
                        }
                        else
                        {
                            
                            Console.WriteLine("Invalid choice!");
                        }

                        break;

                    case 2:
                        IDatabase db2 = new Oracle();
                        Console.WriteLine("enter which operation to perform");
                        Console.WriteLine("1:insert 2:delete 3:update 4:deleteAll 5:updateAll");
                        int choice1 = Convert.ToInt32(Console.ReadLine());
                        if (choice1 == 1)
                        {
                            db2.insert();
                        }
                        else if (choice1 == 2)
                        {
                            db2.delete();
                        }
                        else if (choice1 == 3)
                        {
                            db2.update();
                        }
                        else if (choice1 == 4)
                        {
                            db2.deleteAll();
                        }
                        else if (choice1 == 5)
                        {
                            db2.updateAll();
                        }
                        else if (choice1 == 0)
                        {
                            Console.WriteLine("exit");
                        }
                        else
                        {
                            
                            Console.WriteLine("Invalid choice!");
                        }
                        break;

                        case 0:
                        Console.WriteLine("exit");
                        break;
                }



                
            }while (ch != 0) ;
            }
    }

}