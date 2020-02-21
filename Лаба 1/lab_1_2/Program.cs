using System;

namespace lab_1_2
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello, {0}", myName);
        }
    }
}
