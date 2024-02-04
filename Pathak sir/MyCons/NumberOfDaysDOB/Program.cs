using System;
using System.Threading;

namespace NumberOfDaysDOB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year:");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birth month:");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birth day:");
            int birthDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(birthYear+":"+birthMonth + ":" + birthDay);

            int daysInBirthDate = (birthYear * 365) + (birthMonth * 30) + birthDay;
            int daysInCurrentDate = (2023 * 365) + (12 * 30) + 22;
            int count = 0;
            for (int i = birthYear; birthYear <= 2023; i++)
            {
                if (i % 4 == 0 && i % 100 != 0)
                {
                    count++;
                }

            }
            int numberOfDays = daysInCurrentDate - daysInBirthDate;
            

            Console.WriteLine("Number of days since your birth: {0}", numberOfDays+count);

            Console.ReadLine();
        }
    }
}
