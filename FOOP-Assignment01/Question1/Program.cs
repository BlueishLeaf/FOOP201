using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOPAssignment
{
    class Program
    {
        //Constant declarations
        private const double PRICE_PER_KM = 0.45;
        private const double PRICE_PER_SQMETER = 3.25;

        static void Main(string[] args)
        {
            Console.WriteLine("Carpet Price Calculator");
            Console.WriteLine();
            //Keeps track of the total cost of all fittings and number of fittings
            double totalCost = 0;
            int numFittings = 0;
            bool calculating = true;
            do
            {
                //Get user input
                Console.Write("Enter a distance in kilometers: ");
                double kmTravelled = double.Parse(Console.ReadLine());
                Console.Write("Enter a carpet size: ");
                double carpetSize = double.Parse(Console.ReadLine());

                //Call CalcPrice to get the fitting cost, passing both totalCost and numFittings by reference to change their value
                double fittingCost = CalcPrice(kmTravelled,carpetSize,ref totalCost, ref numFittings);
                Console.WriteLine();

                //Print out the cost of this fitting, rounding result to two decimal places
                Console.WriteLine("Cost of fitting = EUR "+Math.Round(fittingCost,2));
                Console.WriteLine();

                //Ask user to continue calculating or to end
                Console.Write("Enter a 0 to end or 1 to calculate again: ");
                int userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 1) { }
                else if (userChoice == 0)
                {
                    calculating = false;
                }
                Console.WriteLine();

            }
            while (calculating);

            //Call method to display the totals
            DisplayTotal(totalCost, numFittings);

        }

        //Calculated the price of the current fitting, taking into account a discount.
        static double CalcPrice(double kmTravelled, double carpetSize, ref double totalCost, ref int numFittings)
        {
            const double DISCOUNT_CUTOFF = 250;
            const double DISCOUNT_RATE = .1;
            double fittingCost = (PRICE_PER_KM * kmTravelled) + (PRICE_PER_SQMETER * carpetSize);
            if (fittingCost>DISCOUNT_CUTOFF)
            {
                fittingCost = fittingCost - (fittingCost*DISCOUNT_RATE);
            }
            totalCost+=fittingCost;
            numFittings++;
            return fittingCost;
        }

        //Print both the total cost and average cost of all fittings to the console, rounded to two decimal places
        static void DisplayTotal(double totalCost, int numFittings)
        {
            Console.WriteLine("Total Costs: EUR " + Math.Round(totalCost,2));
            Console.WriteLine("Average Costs: EUR " + Math.Round((totalCost / numFittings),2));
        }
        }
    }
