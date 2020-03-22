using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation_of_the_progression
{
    class ArithmeticProgression : Progression
    {
        public int k { get; set; }
        // Конструктор класса
        public ArithmeticProgression(int K)
        {
            this.k = K;
        }
        // Переписанный метод
        public int GetElement()
        {
            int sum = 0;
            for (int i = 0; i <= this.k; i++)
                sum += i;
            return sum;
        }
    }
}
