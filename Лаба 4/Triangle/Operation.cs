using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Operation
    {

        public static double Square(double P)
        {
            try
            {
                if (P <= 0)
                    throw new Exception("Perimeter less that 0");

                double a = P / 3;
                double S = Math.Sqrt(P * Math.Pow((P - a), 3));
                return S;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                return 0;
            }
        }
        public static double Square(double a, double b, double c)
        {
            try
            {
                if (a >= b + c || b >= a + c || c >= a + b)
                    throw new Exception("Incorrect side length");

                double P = a + b + c;
                double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                return S;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                return 0;
            }
        }
    }
}
