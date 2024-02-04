namespace CMath
{
    public class MyMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        private int Sub(int x, int y)
        {
            return x - y;
        }
        protected int Mult(int x, int y)
        {
            return x * y;
        }
        internal int Div(int x, int y)
        {
            return x / y;
        }
        protected internal int Square(int x)
        {
            return x * x;
        }
    }
}