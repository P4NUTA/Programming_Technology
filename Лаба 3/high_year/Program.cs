using System;

namespace high_year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Write year");
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Yes");
            }else
            {
                Console.WriteLine("No");
            }
        }
    }
}
