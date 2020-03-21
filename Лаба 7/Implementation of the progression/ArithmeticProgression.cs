using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation_of_the_progression
{
    class ArithmeticProgression : Progression
    {
        // Конструктор класса
        public ArithmeticProgression(int K) : base(K) { }
        // Переписанный метод
        public override int GetElement()
        {
            int sum=0;
            for (int i = 0; i <= k; i++)
                sum += i;
            return sum;
        }
    }
}
