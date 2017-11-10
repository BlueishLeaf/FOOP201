using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] priceArray = new double[2] { 15000, 24000 };
            Console.Write("Enter price of car sold : ");
            double carPrice = double.Parse(Console.ReadLine());
            double commission = 0;
            if (carPrice<=15000)
            {
                commission = carPrice * 0.05;
            }
            else if (carPrice<=24000)
            {
                commission = carPrice * 0.07;

            }
            else if (carPrice > 24000)
            {
                commission = carPrice * 0.1;

            }
            Console.WriteLine("Your commission is : " + commission);
        }
    }
}
