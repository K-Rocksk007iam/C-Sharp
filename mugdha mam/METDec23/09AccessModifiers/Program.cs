
using CMath;

namespace _09AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Same Assembly 
            //CMath cmath =new CMath();
            //cmath.Add(10,20);
            //cmath.Square(10);
            //cmath.Div(10, 2); 
            #endregion

            MyMath obj=new MyMath();
            obj.Add(10, 20);
            MyClass myClass = new MyClass();
            ///myClass.

        }
    }
    public class MyClass:MyMath
    {
        public int WrapperMult(int x,int y)
        {
           return base.Mult(x,y);
        }
    }

    //public class CMath
    //{
    //    public int Add(int x,int y)
    //    {
    //        return x + y;
    //    }
    //    private int Sub(int x,int y) 
    //    {
    //        return x - y;
    //    }
    //    protected int Mult(int x,int y) 
    //    {
    //        return x * y;
    //    }
    //    internal int Div(int x,int y) 
    //    {
    //        return x / y;
    //    }
    //    protected internal int Square(int x)
    //    {
    //        return x * x;
    //    }
    //}
}