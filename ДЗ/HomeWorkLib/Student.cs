using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class Student : Person
    {
        // Student's group
        public string group;
        // Student's faculty
        public string faculty;
        /// <summary>
        /// Конструктор класса
        /// <para>@param string name - Student's name</para>
        /// <para>@param string secondname - Student's secondname</para>
        /// <para>@param string surname - Student's surname</para>
        /// <para>@param int bday - Student's birthday</para>
        /// <para>@param int bmonth- Student's birthmonth</para>
        /// <para>@param int byear - Student's birthyear</para>
        /// <para>@param string group - Student's group </para>
        /// <para>@param string faculty- Student's faculty</para>
        /// </summary>
        public Student(string name, string secondname, string surname, int bday, int bmonth, int byear, string group, string faculty) : base(name, secondname, surname, bday, bmonth, byear)
        {
            this.group = group;
            this.faculty = faculty;
        }
        /// <summary>
        /// Вывод полной информации студента 
        /// </summary>
        public void WriteFullInfo()
        {
            WriteFIO();
            Console.WriteLine("Group = {0}", this.group);
            Console.WriteLine("Faculty = {0}", this.faculty);
        }
    }
}
