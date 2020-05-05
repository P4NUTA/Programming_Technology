using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class Educator : Person , IEmployee
    {        
        // Educator's position
        public int position;
        // Educator's faculty
        public string faculty;
        // Educator's experience
        public int experience;
        public int salary;
        /// <summary>
        /// Конструктор класса
        /// <para>@param string name - Educator's name</para>
        /// <para>@param string secondname - Educator's secondname</para>
        /// <para>@param string surname - Educator's surname</para>
        /// <para>@param string birthday - Educator's birthday</para>
        /// <para>@param string position - Educator's position </para>
        /// <para>@param string faculty- Educator's faculty</para>
        /// <para>@param int experience- Educator's experience</para>
        /// </summary>
        public Educator(string name, string secondname, string surname, int bday, int bmonth, int byear, int position, string faculty, int experience) : base(name, secondname, surname, bday, bmonth, byear)
        {
            this.position = position;
            this.faculty = faculty;
            this.experience = experience;
            this.salary = Salary(this.position);
        }
        /// <summary>
        /// Вывод полной информации преподавателя 
        /// </summary>
        public void WriteFullInfo()
        {
            WriteFIO();
            Console.WriteLine("Position = {0}", this.position);
            Console.WriteLine("Faculty = {0}", this.faculty);
            Console.WriteLine("Experience= {0}", this.experience);
        }
        public int Salary(int position){
            return (2 * position);
        }
    }
}
