using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Book : Object
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public virtual double Price { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", ISBN, Title, Author, Price);
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
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class TextBook : Book
    {
        public char GradeLevel { get; set; }
        public override double Price
        {
            get { return base.Price; }

            set
            {
                if (value >= 20 && value <= 80)
                {
                    base.Price = value;
                }
                else
                {
                    base.Price = 0;
                }

            }

        }
        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", ISBN, Title, Author, Price, GradeLevel);
        }

    }

    class CoffeeTableBook : Book
    {
        private double price;
        public override double Price
        {
            get { return base.Price; }

            set
            {
                if (value >= 35 && value <= 100)
                {
                    base.Price = value;
                }
                else
                {
                    base.Price = 0;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            TextBook b2 = new TextBook();
            CoffeeTableBook b3 = new CoffeeTableBook();

            b1.ISBN = 1234;
            b1.Title = "test1";
            b1.Author = "testa";
            b1.Price = 90.45;

            b2.ISBN = 1234;
            b2.Title = "test2";
            b2.Author = "testb";
            b2.Price = 40.45;
            b2.GradeLevel = 'A';

            b3.ISBN = 4321;
            b3.Title = "test3";
            b3.Author = "testc";
            b3.Price = 90;

            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());
            Console.WriteLine(b3.ToString());

            Console.WriteLine(b1.Equals(b2));

        }
    }
}