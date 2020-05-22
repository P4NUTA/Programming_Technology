using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student("Павел", "Леонидович", "Ефимов", 4, 10, 2001, "К3120", "ФИКТ");
            Manager m = new Manager("Иван", "Иванович", "Иванов", 1, 1, 1999, 1, "КТУ");
            Administrator a = new Administrator("Михаил", "Михаилович", "Михаилов", 19, 9, 1991, "Химический");
            Educator e = new Educator("Алексей", "Алексеевич", "Алексеев", 4, 10, 1993, 2, "ТИНТ", 4);

            List<Person> T = new List<Person>();
            T.Add(p);
            T.Add(m);
            T.Add(a);
            T.Add(e);

            Console.WriteLine("Информация о сотрудниках");
            foreach (Person i in T)
                i.WriteFIO();

            Console.WriteLine("------------------------");
            Console.WriteLine("Информация о сотрудниках от 17 до 22 лет");
            foreach (Person i in T)
                if (i.ages > 17 && i.ages < 22)
                    i.WriteFIO();


        }
    }
}
