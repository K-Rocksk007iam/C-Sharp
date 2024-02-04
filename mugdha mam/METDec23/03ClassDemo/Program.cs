namespace _03ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Int 
            //Console.WriteLine("Enter value for x :");
            //int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter value for y : ");
            //int y = Convert.ToInt32(Console.ReadLine());

            //int addResult = x + y;

            //Console.WriteLine("Add Result  = " + addResult.ToString());
            #endregion

            #region For Double 
            //Console.WriteLine("Enter value for x :");
            //string xVal = Console.ReadLine();
            //double x = Convert.ToDouble(xVal);
            ////Console.WriteLine(x);

            //Console.WriteLine("Enter value for y : ");
            //double y = Convert.ToDouble(Console.ReadLine());

            //double addResult = x + y;

            //Console.WriteLine("Add Result  = " + addResult.ToString()); 
            #endregion

            #region Overloading across the classes 
            //CMath cmath = new CMath();
            //int addResult =cmath.Add(10, 20);
            //Console.WriteLine(cmath.Sub(22,10));

            //AdvanceMath advMath= new AdvanceMath();
            //Console.WriteLine(advMath.Square(10));
            //Console.WriteLine(advMath.Add(10, 20));
            //Console.WriteLine(advMath.Add(10, 20, 30));
            //Console.WriteLine(advMath.Add(10,20));
            //Console.WriteLine();

            //CMath cmath = new AdvanceMath(); 
            #endregion

            //AdvanceMath obj=new AdvanceMath();
            //Console.WriteLine(obj.Add(100,200));
            //Console.WriteLine(obj.Mult(2,3));
            //obj.SayHi();
            //obj.SayBye();

            Custormer custormer = new Custormer(10,"Om","Goa");
        }

    }

}