namespace _05Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cMath = new CMath();
            IX xObj = new CMath();
            Console.WriteLine($"X.Add = {xObj.Add(10, 20)}");
            IY yObj =new CMath();
            Console.WriteLine("Y.Add = {0}",yObj.Add(10,20));
            //cMath.Add(10, 20);
            //cMath.Sub(10, 20);
            //cMath.Square(10);
            int n1=1, n2 = 2;
           // Console.WriteLine("n1= {0},n2 = {1}, n3 ={0}",n1,n2);
            
            string formatedString = String.Format("n1= {0},n2 = {1}, n3 ={0}", n1, n2);
            Console.WriteLine(formatedString);
        }
    }


    public interface IX
    {
        int Add(int x, int y);
        int Sub(int x, int y);

    }
    public interface IY
    {
        int Add(int x, int y);
        int Sub(int x, int y);
        int Square(int x);

    }

    public class CMath : IX, IY
    {
        #region Implicit Implementation 
        //public int Add(int x, int y)
        //{
        //    return x + y;
        //}

        //public int Square(int x)
        //{
        //    return x * x;
        //}

        //public int Sub(int x, int y)
        //{
        //    return x - y;
        //} 
        #endregion
        int IX.Add(int x, int y)
        {
            return x + y;
        }

        int IY.Add(int x, int y)
        {
            return x + y + 100;
        }

        int IY.Square(int x)
        {
            return x * x;
        }

        int IX.Sub(int x, int y)
        {
            return x-y;
        }

        int IY.Sub(int x, int y)
        {
            return x - y *10;
        }
    }

}