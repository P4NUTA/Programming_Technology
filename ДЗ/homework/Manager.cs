using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class Manager : Person, IEmployee
    {
        // Manager's position
        public int position;
        // Manager's faculty
        public string faculty;
        public int salary;
        /// <summary>
        /// Конструктор класса
        /// <para>@param string name - Manager's name</para>
        /// <para>@param string secondname - Manager's secondname</para>
        /// <para>@param string surname - Manager's surname</para>
        /// <para>@param string birthday - Manager's birthday</para>
        /// <para>@param string position - Manager's position </para>
        /// <para>@param string faculty- Manager's faculty</para>
        /// </summary>
        public Manager(string name, string secondname, string surname, int bday, int bmonth, int byear, int position, string faculty) : base(name, secondname, surname, bday, bmonth, byear)
        {
            this.position= position;
            this.faculty = faculty;
            this.salary = Salary(this.position);
        }
        /// <summary>
        /// Вывод полной информации менеджера 
        /// </summary>
        public void WriteFullInfo()
        {
            WriteFIO();
            Console.WriteLine("Position = {0}", this.position);
            Console.WriteLine("Faculty = {0}", this.faculty);
        }
        public int Salary(int position)
        {
            return (2 * position);
        }
    }
}
