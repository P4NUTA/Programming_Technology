using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод периметра
            double S = Operation.Square(30);
            Console.WriteLine("S = {0}", S);
            // Ввод сторон
            S = Operation.Square(20, 20, 20);
            Console.WriteLine("S = {0}", S);
        }
    }
}
