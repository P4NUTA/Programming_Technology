using System;

namespace lab_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the triangle perimeter");
                string temp = Console.ReadLine();
                double P = Double.Parse(temp);
                if (P <= 0)
                {
                    throw new Exception("Perimeter less than 0");
                }
                double a = P / 3;
                double S = Math.Sqrt(P * Math.Pow((P - a), 3));
                Console.WriteLine("Side\tSquare");
                Console.WriteLine("{0:F}\t{1:F}", a, S);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
        }
    }
}
