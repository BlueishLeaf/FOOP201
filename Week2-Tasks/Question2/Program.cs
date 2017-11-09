using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] tipArray = new double[7];
            Console.WriteLine("Enter total tips for each day.");
            for (int i=0;i<tipArray.Length;i++)
            {
                Console.Write("Tips for day No."+(i+1)+" : ");
                tipArray[i] = double.Parse(Console.ReadLine());
            }
            double totalTips = tipArray.Sum();
            double averageTips = totalTips / tipArray.Length;

            Console.WriteLine("Tip information.");
            for (int i = 0; i < tipArray.Length; i++)
            {
                Console.WriteLine("Tips for day No." + (i + 1) + " : "+tipArray[i]);
                Console.WriteLine("Todays tips were " + (tipArray[i]-averageTips) + " away from the average of "+averageTips );
            }
        }
    }
}
