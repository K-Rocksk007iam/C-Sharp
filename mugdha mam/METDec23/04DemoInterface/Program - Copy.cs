//using System.Security.Cryptography.X509Certificates;

//namespace _04DemoInterface
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter your choice: 1. SQL 2.Oracle");
//            int choice = Convert.ToInt32(Console.ReadLine());
//            switch (choice)
//            {
//                case 1:
//                    SQLServer sqlObj=new SQLServer();
//                    Console.WriteLine("Tell us what do you want to do:");
//                    Console.WriteLine("1.Insert, 2. Update, 3.Delete");
//                    int sqlch =Convert.ToInt32(Console.ReadLine());
//                    switch (sqlch)
//                    {
//                        case 1:
//                            sqlObj.InsertIntoSQLServerDB();
//                            break;
//                            case 2:
//                            sqlObj.UpdateIntoSQLServerDB();
//                            break;
//                            case 3:
//                            sqlObj.DeleteIntoSQLServerDB();
//                            break;
//                        default:
//                            Console.WriteLine("Invalid choice");
//                            break;
//                    }
//                    break;
//                    case 2:
//                    OracleServer oracleObj=new OracleServer();
//                    Console.WriteLine("Tell us what do you want to do:");
//                    Console.WriteLine("1.Insert, 2. Update, 3.Delete");
//                    int orchoice = Convert.ToInt32(Console.ReadLine());
//                    switch (orchoice)
//                    {
//                        case 1:
//                            oracleObj.InsertIntoOracleServerDB();
//                            break;
//                        case 2:
//                            oracleObj.UpdateIntoOracleServerDB();
//                            break;
//                        case 3:
//                            oracleObj.DeleteIntoOracleServerDB();
//                            break;
//                        default:
//                            Console.WriteLine("Invalid choice");
//                            break;
//                    }                    
//                    break;
//                default:
//                    Console.WriteLine("Invalid Choice");
//                    break;
//            }
//        }
        
//    }
//    public class SQLServer
//    {
//        public void InsertIntoSQLServerDB()
//        {
//            //code here
//            //code here
//            //code here
//            Console.WriteLine("Data Inserted into SQL Server");
//        }
//        public void UpdateIntoSQLServerDB()
//        {
//            //code here
//            Console.WriteLine("Data Updated into SQL Server");
//        }
//        public void DeleteIntoSQLServerDB()
//        {
//            //code here
//            Console.WriteLine("Data Deleted into SQL Server");
//        }

//    }
//    public class OracleServer
//    {
//        public void InsertIntoOracleServerDB()
//        {
//            //code here
//            //code here
//            //code here
//            Console.WriteLine("Data Inserted into Oracle Server");
//        }
//        public void UpdateIntoOracleServerDB()
//        {
//            //code here
//            Console.WriteLine("Data Updated into Oracle Server");
//        }
//        public void DeleteIntoOracleServerDB()
//        {
//            //code here
//            Console.WriteLine("Data Deleted into Oracle Server");
//        }
//    }
//}