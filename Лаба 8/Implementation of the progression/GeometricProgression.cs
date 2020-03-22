using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation_of_the_progression
{
    class GeometricProgression : Progression
    {
        public int k { get; set; }
        // Конструктор класса
        public GeometricProgression(int K)
        {
            this.k = K;
        }
        // Переписанный метод
        public int GetElement()
        {
            int sum = 1;
            for (int i = 1; i <= this.k; i++)
                sum *= i;
            return sum;
        }
    }
}
