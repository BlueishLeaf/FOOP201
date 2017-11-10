using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] itemArray = new string[5, 2];
            Console.Write("Enter item number : ");
            int index = int.Parse(Console.ReadLine())-1;
            int x = 0;
            foreach (string line in File.ReadLines("items.csv"))
            {
                string[] values = line.Split(',');
                itemArray[x, 0] = values[0];
                itemArray[x, 1] = values[1];
                x++;

            }
            Console.WriteLine("{0,-15}{1,-15}",itemArray[index, 0], itemArray[index, 1]);

            Console.Write("Enter minimum selling price : ");
            double minPrice = double.Parse(Console.ReadLine());
            for (int i=0;i<5;i++)
            {
                if (minPrice <= double.Parse(itemArray[i,1]))
                {
                    Console.WriteLine("{0,-15}{1,-15}", itemArray[i, 0], itemArray[i, 1]);
                }
            }
        }
    }
}
