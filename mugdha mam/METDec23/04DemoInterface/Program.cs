using System.Security.Cryptography.X509Certificates;

namespace _04DemoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice: 1. SQL 2.Oracle 3. MySQL");
            int choice = Convert.ToInt32(Console.ReadLine());
            DBFactory dBFactory = new DBFactory();
            IDatabase db = dBFactory.GetDB(choice);
            Console.WriteLine("Tell us what do you want to do:");
            Console.WriteLine("1.Insert, 2. Update, 3.Delete");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:                 
                       db.Insert();
                       break;
                case 2:
                       db.Update();
                       break;
                case 3:
                       db.Delete();
                       break;
                default:
                       Console.WriteLine("Invalid choice");
                       break;
                    
            }
        }
        
    }
    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }
    public class DBFactory //Factory Classes
    {
        public IDatabase GetDB(int choice) // Factory methods
        {
            if(choice == 1)
            {
                return new SQLServer();
            }
            else if(choice == 2)
            {
                return new OracleServer();
            }
            else if(choice == 3)
            {
                return new MySQLServer();
            }
            else
            {
                return null;
            }
        }
    }
    public class SQLServer:IDatabase
    {
        public void Insert()
        {
            //code here
            //code here
            //code here
            Console.WriteLine("Data Inserted into SQL Server");
        }
        public void Update()
        {
            //code here
            Console.WriteLine("Data Updated into SQL Server");
        }
        public void Delete()
        {
            //code here
            Console.WriteLine("Data Deleted into SQL Server");
        }

    }
    public class OracleServer :IDatabase
    {
        public void Insert()
        {
            //code here
            //code here
            //code here
            Console.WriteLine("Data Inserted into Oracle Server");
        }
        public void Update()
        {
            //code here
            Console.WriteLine("Data Updated into Oracle Server");
        }
        public void Delete()
        {
            //code here
            Console.WriteLine("Data Deleted into Oracle Server");
        }
    }
    public class MySQLServer : IDatabase
    {
        public void Insert()
        {
            //code here
            //code here
            //code here
            Console.WriteLine("Data Inserted into MySQL Server");
        }
        public void Update()
        {
            //code here
            Console.WriteLine("Data Updated into MySQL Server");
        }
        public void Delete()
        {
            //code here
            Console.WriteLine("Data Deleted into MySQL Server");
        }
    }
}