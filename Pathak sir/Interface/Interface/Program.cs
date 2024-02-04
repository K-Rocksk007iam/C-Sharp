using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class One : Interface1
    {

        public int add(int a, int b)
        {
            return a + b;

        }
        public int sub(int a, int b)
        {
            return a - b;
        }
    }
    class Two : Interface1
    {

        public int add(int a, int b)
        {
            return a + b;

        }
        public int sub(int a, int b)
        {
            return a - b;
        }
    }
    class Solution
    {
        static void Main(string[] args)
        {
            One one = new One();

            Console.WriteLine(one.add(5, 5));
            Console.WriteLine(one.sub(15, 5));
            Console.ReadLine();
        }
    }
    
}
