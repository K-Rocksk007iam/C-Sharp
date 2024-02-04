using System;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n1, n2, n3, n4, n5;
            int even=0;
            int odd = 0;
            int[] arr = new int[5];
            Console.WriteLine("Enter array elemnt :");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine("array elemnts are:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
              Console.WriteLine(arr[i]);
            }
            Console.WriteLine("even :" + even);
            Console.WriteLine("odd :" + odd);
            Console.ReadLine();
        }
    }
}
