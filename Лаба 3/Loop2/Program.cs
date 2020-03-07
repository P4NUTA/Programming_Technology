using System;

namespace Loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных
            double x, x1, x2;
            double y;
            // Ввод значений
            Console.WriteLine("x1 =");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("x2 =");
            x2 = double.Parse(Console.ReadLine());
            x = x1;

            Console.WriteLine("do while");
            Console.WriteLine("x\ty");
            // цикл с постусловием
            do
            {
                y = Math.Sin(x);
                Console.WriteLine("{0}\t{1}", x, y);
                x += 0.01;
            }
            while (x <= x2);

            x = x1;
            Console.WriteLine("while");
            Console.WriteLine("x\ty");
            // Цикл с предусловием
            while (x <= x2)
            {
                y = Math.Sin(x);
                Console.WriteLine("{0}\t{1}", x, y);
                x += 0.01;
            }

            // цикл с постусловием
            // Ввод значений
            Console.Write("a = ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int B = int.Parse(Console.ReadLine());
            int a = A;
            int b = B;
            // Алгоритм Евклида с постусловием
            Console.WriteLine("do while");
            int temp = a;
            do
            {
                a = temp;
                if (a == b) break;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            while (temp != b);
            Console.WriteLine("temp = {0}", temp);
            // Предусловие
            a = A;
            b = B;
            Console.WriteLine("while");
            while (temp != b)
            {
                a = temp;
                if (a == b) break;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.WriteLine("temp = {0}", temp);
        }
    }
}