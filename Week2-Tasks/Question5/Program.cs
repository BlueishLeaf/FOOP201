using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sizes = new string[4] { "S", "M", "L", "X" };
            double[] prices = new double[4] { 6.99, 8.99, 12.50, 15.00 };
            Console.Write("How many pizzas will you be ordering? : ");
            int numPizzas = int.Parse(Console.ReadLine());
            double total=0;
            for (int i=0;i<numPizzas;i++)
            {
                Console.Write("Choose a pizza size! (S,M,L,X) : ");
                string choice = Console.ReadLine();
                Console.WriteLine("This pizza will cost : " + prices[Array.IndexOf(sizes, choice)]);
                total += prices[Array.IndexOf(sizes, choice)];
            }
            double discount = 0;
            if (numPizzas==2)
            {
                discount = total * 0.1;
            }
            else if (numPizzas == 3 && numPizzas == 4)
            {
                discount = total * 0.15;

            }
            else if (numPizzas>=5)
            {
                discount = total * 0.2;

            }
            Console.WriteLine("Your discounted total price is : "+(total-discount));
        }
    }
}
