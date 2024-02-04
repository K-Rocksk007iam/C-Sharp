namespace _10Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First 
            //Customer customer = new Customer();
            //customer.Id = 10;
            //customer.Name = "Hugh Jackman";

            ////int id = customer.Id;
            //Console.WriteLine($"Id = {customer.Id}, Name={customer.Name}"); 
            #endregion

            Console.WriteLine("Enter ID :");
            int id = Convert.ToInt32(Console.ReadLine());
            Customer customer = new Customer();
            customer.Id = id;
            Console.WriteLine("Enter your name");
            customer.Name = Console.ReadLine();
            Console.WriteLine(customer.Name);
        }
    }
    public class Customer
    {
        private int _CId;
        private string _CName;

        //Property Syntax
        public int Id
        {
            set
            {
                if (value < 100)
                {
                    _CId = value;
                }
                else
                {
                    Console.WriteLine("Value is greater than 100.");
                }
            }
            get
            {
                return _CId;
            }
        }

        public string Name
        {
            set
            {
                _CName = value;
            }
            get
            {
                return "Hello "+ _CName;
            }
        }

        // public void SetCid(int id)
        //{
        //    _cid= id;
        //}
        //public int GetCid()
        //{
        //    return _cid;
        //}
    }
}