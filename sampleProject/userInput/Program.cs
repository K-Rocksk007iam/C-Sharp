namespace userInput
{
    public class Program
    {
        public static int addition(int num1 , int num2)
        {
            return num1+ num2 +1000;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers to add");
            int num1 =Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            
            System.Console.WriteLine("addtion is :"+addition(num1, num2).ToString());
        }
    }
}