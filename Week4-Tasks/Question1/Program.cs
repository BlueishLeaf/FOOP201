using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Lunch
    {
        public string entree { get; set; }
        public string side { get; set; }
        public string drink { get; set; }

        public Lunch(string entree, string side, string drink)
        {
            this.entree = entree;
            this.side = side;
            this.drink = drink;
            Console.WriteLine("{0} {1} {2}",entree,side,drink);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Lunch[] lunchArray = new Lunch[10];
            bool newLunch =true;
            do
            {
                Console.Write("Do you want to add a new lunch?(y/n): ");
                if (Console.ReadLine()=="y")
                {
                    AddLunch(lunchArray);
                }
                else
                {
                    newLunch = false;
                }
            }
            while (newLunch==true);

        }

        static void AddLunch(Lunch[] lunchArray)
        {
            string entree = Console.ReadLine();
            string side = Console.ReadLine();
            string drink = Console.ReadLine();
            lunchArray[0] = new Lunch(entree,side,drink);

        }
    }
}
