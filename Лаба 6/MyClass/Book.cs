using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Book
    {
        public string Author { get; set; } // автор
        public string Title { get; set; } // название
        public string Publisher { get; set; } // издательство
        public int Pages { get; set; } // кол-во страниц
        public int Year { get; set; } // год издания

        private static double price = 9;
        public static double Price
        {
            get { return price; }
            set { if (value > 9) price = value; }
        }
        public void SetBook(string author, string title, string publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }
        public static void SetPrice(double price)
        {
            Book.Price = price;
        }
        public override string ToString()
        {
            string bs = String.Format("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n Стоимость аренды: {4}", Author, Title, Year, Pages, Book.price);
            return bs;
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
        public Book(string author, string title, string publisher, int pages, int year)

        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }
        public Book() { }
        static Book()
        {
            Price = 9;
        }
        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }
    }
}
