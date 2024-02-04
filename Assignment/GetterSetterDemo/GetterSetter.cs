namespace GetterSetterDemo
{
    public class GetterSetter
    {
        static void Main(string[] args)
        {
            Student std1 = new Student(10,"kunal","nashik road , nashik");
            Console.WriteLine($"roll no:{std1.Id } name is:{std1.Name} Address is:{std1.Address}");
           
        }
    }
    public class Student
    {
        private int _SId;
        private string _SName;
        private String _SAddress;

        public Student(int sId, string sName, string sAddress)
        {
            _SId = sId;
            _SName = sName;
            _SAddress = sAddress;
        }

        public int Id
        {
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Enter valid Roll NO");
                }
                else
                {
                    _SId = value;
                }
            }
            get
            {
                return +_SId;
            }
        }

        public String Name
        {
            set
            {
                _SName = value;
            }
            get
            {
                return _SName;
            }
        }
        public String Address
        {
            set
            { 
                _SAddress = value; 
            }
            get
            {
                return _SAddress;
            }
        }

    }
}