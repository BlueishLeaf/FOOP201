using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    class Book : Object
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public virtual double Price { get; set; }
        public Book(int isbn, string title, string author, double price) 
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Price = price;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Book tempBook = (Book)obj;
            if (tempBook.ISBN == this.ISBN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class TextBook : Book
    {
        public string Grade { get; set; }
        public override double Price {
            get { return base.Price; }
            set
            {
                if (value >= 20.00 && value <= 80.00)
                {
                    Price=value;
                }
            }
        }

        public TextBook(string grade) : base(1234, "testbook", "testtitle", 40)
        {
            Grade = grade;
        }
    }

    class CoffeeTableBook : Book
    {
        public override double Price
        {
            get { return base.Price; }
            set
            {
                if (value >= 35.00 && value <= 100.00)
                {
                    Price = value;
                }
            }
        }
        public CoffeeTableBook() : base(1234, "testbook", "testtitle", 50)
        {
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Book txt1 = new Book(1234,"test1","testa",100);
            Book txt2 = new Book(1235, "test2", "testb", 200);
            Console.WriteLine(txt1.Equals(txt2));

        }
    }
}
