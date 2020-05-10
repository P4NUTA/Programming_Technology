using System;
using System.ComponentModel.DataAnnotations;

namespace Practice_1
{
    class Program
    {
        public static int Bet(int total_value)
        {
            while (true)
            {
                Console.WriteLine("Сделайте вашу ставку");
                try
                {
                    int this_bet = int.Parse(Console.ReadLine());
                    if (this_bet > 0 && this_bet <= total_value)
                    {
                        Console.WriteLine("Ставки сделаны");
                        return this_bet;
                    }
                    else
                    {
                        Console.WriteLine("Вы сделали ставку меньше 0 или больше вашего счета");
                        throw new Exception("Неверно сделанная ставка");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Замечено исключение: {0}", e.Message);
                }
            }
        }
        public static Random random;
        public static int RandomNumber()
        {
            random = new Random();
            return random.Next() % 2;
        }
        public static int Chance()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("На что ставите? ч: четное / н: нечетное");
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.X:
                            Console.WriteLine("Вы поставили на четное");
                            return 0;
                        case ConsoleKey.Y:
                            Console.WriteLine("Вы поставили на нечетное");
                            return 1;
                        default:
                            throw new Exception("Неверно поставленная ставка");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Замечено исключение: {0}", e.Message);
                }
            }
        }
        public static bool Endgame()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Будете продолжать игру?");
                    Console.WriteLine("д: да / н: нет");
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.L:
                            return false;
                        case ConsoleKey.Y:
                            Console.WriteLine("Возращайтесь!");
                            return true;
                        default:
                            throw new Exception("Неверно введенное значение");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Замечено исключение: {0}", e.Message);
                }
            }
        }
        static void Main(string[] args)
        {
            int valuebet;
            int bet;
            bool game;
            int value = 100;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Чет-нечет");
                Console.WriteLine("Ваш счет: {0}", value);
                valuebet = Bet(value);
                if (Chance() == RandomNumber())
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
                game = Endgame();
                if (value == 0 || game)
                {
                    Console.WriteLine("Игра закончена!");
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
