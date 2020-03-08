using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных
            int[] myArray;
            int n = int.Parse(Console.ReadLine());
            myArray = new int[n];
            int i = 0;
            // Ввод значений массива
            for (i = 0; i < myArray.Length; ++i)
            {
                Console.Write("a[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }
            // Проверка четности
            for (i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0) myArray[i] = 0;
            }
            i = 0;
            // while:
            Console.Write("\nwhile: \t\t");
            while (i < myArray.Length)
            {

                Console.Write(" " + myArray[i]);
                i += 1;
            }
            // do while:
            Console.Write("\ndo while: \t");
            i = 0;
            do
            {

                Console.Write(" " + myArray[i]);
                i += 1;
            }
            while (i < myArray.Length);
            // for:
            Console.Write("\nFor: \t\t");
            for (i = 0; i < myArray.Length; i++)
            {
                Console.Write(" " + myArray[i]);
            }
            Console.Write("\nforeach: \t");
            // foreach:
            foreach (int x in myArray) // for из питона
            {
                Console.Write(" {0}", x);
            }
        }
    }
}
