using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation_of_the_progression
{
    class GeometricProgression : Progression
    {
        // Конструктор класса
        public GeometricProgression (int K) : base(K) { }
        // Переписанный метод
        public override int GetElement()
        {
            int sum = 1;
            for (int i = 1; i <= k; i++)
                sum *= i;
            return sum;
        }
    }
}
