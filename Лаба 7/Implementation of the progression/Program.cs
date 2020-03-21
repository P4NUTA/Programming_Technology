using System;

namespace Implementation_of_the_progression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных
            ArithmeticProgression AP = new ArithmeticProgression(5);
            GeometricProgression GP = new GeometricProgression(5);
            // Вывод значений
            Console.WriteLine("ArithmeticProgression: {0}",AP.GetElement());
            Console.WriteLine("GeometricProgression: {0}", GP.GetElement());

        }
    }
}
