using System;

namespace Processing_array_data
{
    class Program
    {
        public static int Summ(int[] Array)
        {
            int Sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                Sum += Array[i];
            }
            return Sum;
        }
        public static double Sr(int[] Array)
        {
            int Sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                Sum += Array[i];
            }
            double sr = Sum / Array.Length;
            return sr;
        }
        public static int Sign_Summ(int[] Array, bool Sign)
        {
            int pol_Sum = 0;
            int otr_Sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > 0)
                    pol_Sum += Array[i];
                else
                    otr_Sum += Array[i];
            }
            if (Sign)
                return pol_Sum;
            else
                return otr_Sum;
        }
        public static int Chet_Summ(int[] Array, bool chet)
        {
            int Sum = 0;
            int num = chet ? 0 : 1;
            for (int i = 0; i < Array.Length; i++)
            {
                if (i % 2 == num)
                    Sum += Array[i];
            }
            return Sum;
        }

        static void Main(string[] args)
        {
            int[] Array;
            Console.Write("Array [n]: ");
            int n = int.Parse(Console.ReadLine());
            Array = new int[n];

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Array [{0}]: ", i);
                Array[i] = int.Parse(Console.ReadLine());
            }
            int Sum, Sum1, Sum2;
            double sr;
            sr = Sr(Array);
            Sum = Summ(Array);
            Sum1 = Sign_Summ(Array, true);
            Sum2 = Chet_Summ(Array, true);

            Console.WriteLine("Sum: {0}", Sum);
            Console.WriteLine("Sr: {0}", sr);
            Console.WriteLine("Sum: {0}", Sum1);
            Console.WriteLine("Sum: {0}", Sum2);
        }
    }
}
