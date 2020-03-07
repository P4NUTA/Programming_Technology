using System;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление и ввод переменных
            Console.WriteLine("k = ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("m = ");
            int m = int.Parse(Console.ReadLine());
            int S = 0;
            // Цикл for
            for (int i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                S += i;
            }
            // Вывод данных
            Console.WriteLine("S = {0}", S);
        }
    }
}
