using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zipCodes = new string[10] {"XO40","F9D1","GH76","HJ76","LP20","TY14","RE40","RR78","IR87","PO90"};
            Console.Write("Enter a zip-code : ");
            string zipCode = Console.ReadLine();
            bool hasCode = false;
            for (int i=0;i<zipCodes.Length;i++)
            {
                if (zipCode==zipCodes[i])
                {
                    hasCode = true;
                }
            }
            if (hasCode==true)
            {
                Console.WriteLine("We deliver to this zip-code!");
            }
            else
            {
                Console.WriteLine("We do not deliver to this zip-code!");
            }

        }
    }
}
