using System;

namespace Shapeifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод чисел
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            float y = float.Parse(Console.ReadLine());
            // Проверка "попадания"
            if (x * x + y * y < 9 && y > 0)
                Console.WriteLine("внутри");
            else if (x * x + y * y > 9 || y < 0)
                Console.WriteLine("вне");
            else Console.WriteLine("на границе");
        }
    }
}
