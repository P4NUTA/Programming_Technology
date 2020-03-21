using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation_of_the_progression
{
    abstract class Progression
    {
        // Переменная
        public int k { get; set; }
        // Конструктор класса
        public Progression(int K)
        {
            this.k = K;
        }
        // Абстрактный метод
        abstract public int GetElement();
    }
}
