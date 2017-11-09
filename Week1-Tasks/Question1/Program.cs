using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.Write("Enter number of wine bottles: ");
            bool wine = Question1(int.Parse(Console.ReadLine()));
            Console.WriteLine(wine);

            Console.WriteLine();

            Console.Write("Enter month as a number: ");
            int monthDays = Question2(int.Parse(Console.ReadLine()));
            Console.WriteLine(monthDays);

            Console.WriteLine();

            double arrayAvg = Question3(numArray);
            Console.WriteLine("The average of every 2nd element in numArray is " + arrayAvg);

            Console.WriteLine();

            Console.Write("Enter first number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = int.Parse(Console.ReadLine());
            int sum = Question4(n1, n2);
            Console.WriteLine(sum);

            Console.WriteLine();

            Console.Write("Enter bank balance: ");
            double bankBal = double.Parse(Console.ReadLine());
            Console.Write("Enter withdrawal amount: ");
            double withdrawalAmnt = double.Parse(Console.ReadLine());
            bool withdrawSuccess = Question5(ref bankBal, withdrawalAmnt);
            Console.WriteLine(withdrawSuccess);

            Console.WriteLine();

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        static bool Question1(int num)
        {
            if (num == 3 || num == 6 || num == 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Question2(int monthNum)
        {
            if (monthNum == 9 || monthNum == 4 || monthNum == 5 || monthNum == 11)
            {
                return 30;
            }

            else if (monthNum == 1 || monthNum == 3 || monthNum == 6 || monthNum == 7 || monthNum == 8 || monthNum == 10 || monthNum == 12)
            {
                return 31;
            }

            else if (monthNum == 2)
            {
                return 28;
            }

            else
            {
                return 0;
            }
        }

        static double Question3(int[] arrayIn)
        {
            int total = 0;
            for (int x = 1; x < arrayIn.Length; x += 2)
            {
                total += arrayIn[x];
            }
            int average = total / 10;
            return average;
        }

        static int Question4(int n1, int n2)
        {
            int total = 0;
            for (int x = n1; x <= n2; x += 2)
            {
                if (x % 2 != 0)
                {
                    total += x;
                }

            }
            return total;
        }

        static bool Question5(ref double bankBal, double withdrawAmnt)
        {
            if (bankBal >= withdrawAmnt)
            {
                bankBal -= withdrawAmnt;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
