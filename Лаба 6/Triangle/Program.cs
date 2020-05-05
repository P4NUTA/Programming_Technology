using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle trg1 = new Triangle(15, 5, 5);
            trg1.SideLength();
            Console.WriteLine("Square: {0}\n",trg1.Square());
            Console.WriteLine("Perimeter: {0}\n",trg1.Perimeter());
        }
    }
}
