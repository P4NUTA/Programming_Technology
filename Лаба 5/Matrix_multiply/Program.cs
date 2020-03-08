using System;

namespace Matrix_multiply
{
    class Program
    {
        private static void Input(int[,] a)
        {
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    Console.Write("Enter value for [{0},{1}] : ", r, c);
                    string s = System.Console.ReadLine();
                    a[r, c] = int.Parse(s);
                }
            }
            Console.WriteLine();
        }
        private static void Output(int[,] result)
        {
            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    Console.Write("{0} ", result[r, c]);
                }
                Console.WriteLine();
            }
        }
        private static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    result[r, c] += a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            a[0, 0] = 1; a[0, 1] = 2;
            a[1, 0] = 3; a[1, 1] = 4;
            int[,] b = new int[2, 2];
            b[0, 0] = 5; b[0, 1] = 6;
            b[1, 0] = 7; b[1, 1] = 8;
            int[,] result = Multiply(a, b);
            /*int[,] result = new int[2, 2];*/
            result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];
            Console.WriteLine(result[0, 0]);
            Console.WriteLine(result[0, 1]);
            Console.WriteLine(result[1, 0]);
            Console.WriteLine(result[1, 1]);

        }
    }
}
