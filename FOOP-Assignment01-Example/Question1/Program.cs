using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOPAssignment01
{
    class Program
    {
        const double PRICE_PER_KM = 1.25;
        const double PRICE_PER_MINUTE = 0.25;
        const double PRICE_PER_PASSENGER = 1;
        const double PRICE_PER_LUGGAGE = 0.5;
        const double TAX = 0.135;

        static void Main(string[] args)
        {
            Console.WriteLine("Taxi Fare Calculator");
            Console.WriteLine();
            double kmTravelled = 0;
            do
            {
                Console.WriteLine("Enter KM travelled >> ");
                kmTravelled = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter minutes taken >> ");
                double minutesTaken = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of passengers >> ");
                int numPassengers = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter pieces of luggage, 0 for none >> ");
                int numLuggage = int.Parse(Console.ReadLine());
                double initialFare = CalcFare(kmTravelled,minutesTaken,numPassengers,numLuggage);
                double totalFare = initialFare + (initialFare * TAX);
                Console.WriteLine();
                Console.WriteLine("Cost of taxi = "+initialFare);
                Console.WriteLine("Tax = "+ (initialFare*TAX));
                Console.WriteLine("Total cost = " + totalFare);
                Console.WriteLine();
            }
            while (kmTravelled != -1);
        }

        static double CalcFare(double kmTravelled, double minutesTaken, int numPassengers, int numLuggage)
        {
            double fare = (kmTravelled * PRICE_PER_KM)+(minutesTaken*PRICE_PER_MINUTE)+(numPassengers*PRICE_PER_PASSENGER)+(numLuggage*PRICE_PER_LUGGAGE);
            return fare;
        }
    }
}
