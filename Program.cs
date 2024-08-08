using System;

namespace TinhNamNhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            int day;
            Console.Write("Enter a year: ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else if (year % 100 == 0 && year % 400 != 0)
                {
                    Console.WriteLine($"{year} is not leap year");
                }
                else if (year % 100 == 0 && year % 400 == 0)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
            }
            else
            {
                Console.WriteLine($"{year} is not leap year");
            }
        }
    }
}