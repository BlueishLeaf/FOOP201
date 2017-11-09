using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] areaCodes = new int[6] { 262, 414, 608, 715, 815, 920 };
            double[] rates = new double[6] { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

            Console.WriteLine("Chat-A-While");
            Console.Write("Enter area code : ");
            int areaCode = int.Parse(Console.ReadLine());
            Console.Write("Enter length of call in memory : ");
            int minutes = int.Parse(Console.ReadLine());

            double callPrice = minutes * rates[Array.IndexOf(areaCodes,areaCode)];
            Console.WriteLine("The price of your call is : " + callPrice);
        }
    }
}
