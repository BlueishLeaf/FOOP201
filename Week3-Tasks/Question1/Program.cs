using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Tasks
{
    class Flight
    {
        public string airlineName { get; set; }
        public int flightNumber { get; set; }
        public int row { get; set; }
        public char seat { get; set; }

        public Flight(string airlineName,int flightNumber, int row, char seat)
        {
            this.airlineName=airlineName;
            this.flightNumber= flightNumber;
            this.row= row;
            this.seat= seat;


        }

        public void WriteDetails()
        {
            Console.WriteLine("{0} {1} {2} {3}", airlineName, flightNumber, row, seat);
        }

    }

    class CashRegister
    {
        public double total { get; set; }
        private static int itemCount;

        public void AddItem()
        {
            Console.Write("Enter price of item: ");
            double newItem = double.Parse(Console.ReadLine());
            total += newItem;
            itemCount++;
            Console.WriteLine("{0} added to total. Total = {1}. Items = {2}", newItem, total, itemCount);
            
        }
    }

    class Square
    {
        public int length { get; set; }
        public int area { get; set; }

        public Square(int length)
        {
            this.length = length;
            CalcArea();
        }

        private void CalcArea()
        {
            area = length * length;
        }
    }

    class Program
    {
        static void Main()
        {
            Flight testFlight = new Flight("Ryanair",103,22,'E');
            testFlight.WriteDetails();

            CashRegister testCash= new CashRegister();
            bool chaChing = true;
            while (chaChing)
            {
                testCash.AddItem();
                Console.Write("Would you like to add another item? (y/n) : ");
                if (Console.ReadLine()=="n")
                {
                    chaChing = false;
                }
            }

            Square[] squareArray = new Square[10];
            for (int i = 0; i < squareArray.Length; i++)
            {
                squareArray[i]=new Square(i+1);
                Console.WriteLine(squareArray[i].area);
            }
        }
    }


}
