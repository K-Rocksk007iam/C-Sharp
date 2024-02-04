namespace _07LoggerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your choice: 1. SQL 2.Oracle 3. MySQL");
                int choice = Convert.ToInt32(Console.ReadLine());
                DBFactory dBFactory = new DBFactory();
                Database db = dBFactory.GetDB(choice);
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
                Console.WriteLine("Do you want to continue> Y/N");
                string ynchoice = Console.ReadLine();
                if(ynchoice == "n")
                {
                    break;
                }
            }
        }
    }
    public abstract class Database
    {
        Logger logger = null;
        public Database()
        {
            logger = Logger.GetLogger();
        }
        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();

        protected abstract string GetDataBaseName();
        public void Insert()
        {
            DoInsert();
            logger.Log($"Record Inserted into {GetDataBaseName()} - Done");
        }
        public void Update()
        {
            DoUpdate();
            logger.Log($"Record Updated into {GetDataBaseName()} - Done");
        }
        public void Delete()
        {
            DoDelete();
            logger.Log($"Record Deleted From {GetDataBaseName()} - Done");
        }
    }
    public class DBFactory //Factory Classes
    {
        public Database GetDB(int choice) // Factory methods
        {
            if (choice == 1)
            {
                return new SQLServer();
            }
            else if (choice == 2)
            {
                return new OracleServer();
            }
            else if (choice == 3)
            {
                return new MySQLServer();
            }
            else
            {
                return null;
            }
        }
    }
    public class SQLServer : Database
    {
        //private Logger logger =null;
        //public SQLServer()
        //{
        //    logger = Logger.GetLogger();
        //}
        protected override string GetDataBaseName()
        {
            return "SQL Server";
        }
        protected override void DoInsert()
        {
            //code here
            //code here
            //code here
            Console.WriteLine("Data Inserted into SQL Server");
            //logger.Log("Record Inserted into SQL - Done");
        }
        protected override void DoUpdate()
        {
            //code here
            Console.WriteLine("Data Updated into SQL Server");
            //logger.Log("Record Updated into SQL - Done");
        }
        protected override void DoDelete()
        {
            //code here
            Console.WriteLine("Data Deleted into SQL Server");
            //logger.Log("Record Deleted into SQL - Done");
        }

    }
    public class OracleServer : Database
    {
        //private Logger logger = null;
        //public OracleServer()
        //{
        //    logger = Logger.GetLogger();
        //}
        protected override string GetDataBaseName()
        {
            return "Oracle Server";
        }
        protected override void DoInsert()
        {
            //code here
            //code here
            //code here
            Console.WriteLine("Data Inserted into Oracle Server");
            //logger.Log("Record Inserted into Oracle - Done");
        }
        protected override void DoUpdate()
        {
            //code here
            Console.WriteLine("Data Updated into Oracle Server");
            //logger.Log("Record Updated into Oracle - Done");
        }
        protected override void DoDelete()
        {
            //code here
            Console.WriteLine("Data Deleted into Oracle Server");
           // logger.Log("Record Deleted into Oracle - Done");
        }
    }
    public class MySQLServer : Database
    {
        //private Logger logger = null;
        //public MySQLServer() // Singleton 
        //{
        //    //logger = new Logger();
        //    logger = Logger.GetLogger();
        //}
        protected override string GetDataBaseName()
        {
            return "MySQL";
        }
        protected override void DoInsert()
        {
            //code here
            //code here
            //code here
            Console.WriteLine("Data Inserted into MySQL Server");
           // logger.Log("Record Inserted into MySQL - Done");
        }
        protected override void DoUpdate()
        {
            //code here
            Console.WriteLine("Data Updated into MySQL Server");
            //logger.Log("Record Updated into MySQL - Done");
        }
        protected override void DoDelete()
        {
            //code here
            Console.WriteLine("Data Deleted into MySQL Server");
            //logger.Log("Record Deleted into MySQL - Done");
        }
    }

    public class Logger
    {
        //Object Pool
        static Logger logger = new Logger();
        static Logger logger1 =new Logger();
        private Logger()
        {
            Console.WriteLine("Logger object created for the First Time---");
        }
        //we might do many File I/O operations before calling Log method

        public static Logger GetLogger()
        {
            return logger;
        }
        public static Logger GetLogger1()
        {
            return logger1;
        }
        public void Log(string message)
        {
            Console.WriteLine("Logged --- "+ message + DateTime.Now.ToString());
        }
    }

}