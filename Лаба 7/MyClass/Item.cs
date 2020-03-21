using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Item
    {
        // инвентарный номер — целое число
        protected long invNumber;
        // хранит состояние объекта - взят ли на руки
        protected bool taken;
        // истина, если этот предмет имеется в библиотеке
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }
        // инвентарный номер
        public long GetInvNumber()
        {
            return invNumber;
        }
        // операция "взять"
        public void Take()
        {
            taken = false;
        }
        // операция "вернуть"
        public void Return()
        {
            taken = true;
        }
        public void Print()
        {
            Console.WriteLine("Состояние единицы хранения:\n Инвентарный номер: {0}\n Наличие: {1}", invNumber, taken);
        }
    }
}
