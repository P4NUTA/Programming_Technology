using System;

namespace Shooter
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, R;
            double points = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("x = ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("y = ");
                y = double.Parse(Console.ReadLine());
                R = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (R <= 1)
                {
                    Console.WriteLine("10 points");
                    points += 10;
                }
                else if (R <= 2)
                {
                    Console.WriteLine("5 points");
                    points += 5;
                }
                else
                {
                    Console.WriteLine("You miss!");
                }
            }
            Console.WriteLine("Points = {0}", points);
        }
    }
}
