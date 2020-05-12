using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    public class Game
    {
        public Game() { }
        public int Bet(int total_value)
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
        public int RandomNumber()
        {
            random = new Random();
            return random.Next() % 2;
        }
        public int Chance()
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
        public bool Endgame()
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
    }
}
