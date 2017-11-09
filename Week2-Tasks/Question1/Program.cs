using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10] {22,5,6,7,9,34,33,77,23,100};
            do
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. View integers from smallest to largest.");
                Console.WriteLine("2. View integers from largest to smallest.");
                Console.WriteLine("3. View an integer at a specified index.");
                Console.Write("Your choice : ");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Array.Sort(intArray);
                        foreach(int element in intArray)
                        {
                            Console.WriteLine(element);
                        }
                        break;

                    case 2:
                        Array.Sort(intArray);
                        Array.Reverse(intArray);
                        foreach (int element in intArray)
                        {
                            Console.WriteLine(element);
                        }
                        break;

                    case 3:
                        Console.Write("Enter an index (0-9) : ");
                        Console.WriteLine(intArray[int.Parse(Console.ReadLine())]);
                        break;

                    default:
                        break;
                }
            } while (true);
        }
    }
}
