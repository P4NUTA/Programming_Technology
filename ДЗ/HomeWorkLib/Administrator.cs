using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class Administrator : Person
    {
        // Administrator's laboratory
        public string laboratory;
        /// <summary>
        /// Конструктор класса
        /// <para>@param string name - Administrator's name</para>
        /// <para>@param string secondname - Administrator's secondname</para>
        /// <para>@param string surname - Administrator's surname</para>
        /// <para>@param int bday - Administrator's birthday</para>
        /// <para>@param int bmonth - Administrator's birthmonth</para>
        /// <para>@param int byear  - Administrator's birthyear</para>
        /// <para>@param string group - Administrator's laboratory</para>
        /// </summary>        
        public Administrator(string name, string secondname, string surname, int bday, int bmonth, int byear, string laboratory) : base(name, secondname, surname, bday, bmonth, byear)
        {
            this.laboratory = laboratory;
        }
        /// <summary>
        /// Вывод полной информации администратора
        /// </summary>
        public void WriteFullInfo()
        {
            WriteFIO();
            Console.WriteLine("laboratory = {0}", this.laboratory);
        }
    }
}