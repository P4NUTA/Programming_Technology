using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    public class Person
    {
        public int valuebet;
        public int value;
        public Game gaming = new Game();
        public Person()
        {
            this.value = 100;
        }
        public bool Ending()
        {
            if (this.value == 0 || gaming.Endgame())
                return true;
            else return false;
        }
        public void Match()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ваш счет: {0}", value);
                valuebet = gaming.Bet(value);
                int random = gaming.RandomNumber();
                if (gaming.Chance() == random)
                {
                    Console.WriteLine("Ваша ставка сыграла");
                    Console.WriteLine("Вы получили {0}", valuebet);
                    value += valuebet;
                }
                else
                {
                    Console.WriteLine("Вы проиграли");
                    Console.WriteLine("Вы потеряли {0}", valuebet);
                    value -= valuebet;
                }
                if (value == 0 || gaming.Endgame())
                {
                    Console.WriteLine("Игра закончена!");
                    break;
                }
            }
        }
    }
}
