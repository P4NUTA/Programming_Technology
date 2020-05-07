using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person("Павел", "Леонидович", "Ефимов", 4, 10, 2001);
            Student p = new Student("Павел", "Леонидович", "Ефимов", 4,10,2001, "К3120", "ФИКТ");
            p.WriteFullInfo();
        }
    }
}
