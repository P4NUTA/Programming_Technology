using System;

namespace SquareRoot
{
    class SquareRoot
    {
        public static int Square(double a, double b, double c, out double x1, out double x2)
        {
            try
            {
                //b^2 - 4ac
                double D = b * b - 4 * a * c;
                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / 2 * a;
                    x2 = (-b - Math.Sqrt(D)) / 2 * a;
                    return 1;
                }
                else if (D == 0)
                {
                    x1 = (-b) / 2 * a;
                    x2 = x1;
                    return 0;
                }
                else
                {
                    throw new Exception("Incorrect equation");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                x1 = -1;
                x2 = -1;
                return -1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // ax^2 + bx + c = 0
            double x1, x2;
            int Square;
            Square = SquareRoot.Square(1, -2, -3, out x1, out x2);
            Console.WriteLine("x1 = {0}\tx2 = {1}\tSquare = {2}", x1, x2, Square);

        }
    }
}
