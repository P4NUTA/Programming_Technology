using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class Person
    {
        // Person's name
        public string name;
        // Person's secondname
        public string secondname;
        // Person's surname
        public string surname;
        public int bday;
        public int bmonth;
        public int byear;
        public int ages;
        /// <summary>
        /// Конструктор класса
        /// <para>@param string name - Person's name</para>
        /// <para>@param string secondname - Person's secondname</para>
        /// <para>@param string surname - Person's surname</para>
        /// <para>@param string birthday - Person's birthday</para>
        /// </summary>        
        public Person(string name, string secondname, string surname, int bday, int bmonth, int byear)
        {
            this.name = name;
            this.surname = surname;
            this.secondname = secondname;
            this.bday = bday;
            this.bmonth = bmonth;
            this.byear = byear;
            ages = Age();

        }
        /// <summary>
        /// Вывод ФИО
        /// </summary>
        public void WriteFIO()
        {
            Console.WriteLine("Surname = {0}", this.surname);
            Console.WriteLine("Secondname = {0}", this.secondname);
            Console.WriteLine("Name = {0}", this.name);
            Console.WriteLine("Ages = {0}", this.ages);
                        
        }
        public int Age()
        {
            int tempDay = DateTime.Now.Day - bday;
            int tempYear = DateTime.Now.Year - byear;
            int tempMonth = DateTime.Now.Month - bmonth;

            if (tempDay < 0)
            {
                tempMonth--;
                tempDay += 30;
            }
            if (tempMonth < 0)
            {
                tempYear--;
            }
            return tempYear;
        }
    }
}
