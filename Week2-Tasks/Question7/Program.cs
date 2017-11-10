using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0;i<5;i++)
            {
                using (StreamWriter writer = new StreamWriter("items.csv",true))
                {
                    Console.Write("Enter name of item to list : ");
                    writer.Write(Console.ReadLine());

                    writer.Write(',');

                    Console.Write("Enter price of item to list : ");
                    writer.WriteLine(Console.ReadLine());

                }

            }
        }
    }
}
