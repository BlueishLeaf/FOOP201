using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3pt3
{
    class Rectangle
    {
        public int width { get; set; }
        public int length { get; set; }
        public int perim { get; }
        public int area { get; }

        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
            perim = CalcPerim();
            area = CalcArea();
        }

        private int CalcPerim()
        {
            int perim = (width * 2) + (length * 2);
            return perim;
        }

        private int CalcArea()
        {
            int area = width * length;
            return area;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec0 = new Rectangle(10, 20);
            Rectangle rec1 = new Rectangle(40, 50);

            if (rec0.perim > rec1.perim)
            {
                Console.WriteLine("Area of largest is: "+rec0.area);
            }
            else
            {
                Console.WriteLine("Area of largest is: " + rec1.area);
            }
        }
    }
}
