using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3pt2
{
    class BankAccount
    {
        public int bankBalance { get; set; }
        public int accNumber { get; set; }
        public int overdraftLim { get; set; }

        public BankAccount(int accNumber, int overdraftLim)
        {
            bankBalance = 0;
            this.accNumber = accNumber;
            this.overdraftLim = overdraftLim;
            PrintDetails();
        }

        private void PrintDetails()
        {
            Console.WriteLine("Account Num is: " + accNumber);
            Console.WriteLine("Bank Bal is: " + bankBalance);
            Console.WriteLine("Overdraft Lim is: " + overdraftLim);
        }

        public void Deposit(int depAmount)
        {
            bankBalance += depAmount;
            PrintDetails();
        }

        public void Withdraw(int witAmount)
        {
            bankBalance -= witAmount;
            PrintDetails();
        }
    }


        class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc0 = new BankAccount(12345678, 5000);
            BankAccount acc1 = new BankAccount(87654321, 9000);
            do
            {
                Console.Write("From which account do you wish to access?(1/2): ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.Write("Deposit or Withdraw?(d/w): ");
                        if (Console.ReadLine() == "d")
                        {
                            Console.Write("Enter Amount: ");
                            acc0.Deposit(int.Parse(Console.ReadLine()));
                        }
                        else if (Console.ReadLine() == "w")
                        {
                            Console.Write("Enter Amount: ");
                            acc0.Withdraw(int.Parse(Console.ReadLine()));
                        }
                        break;
                    case 2:
                        Console.Write("Deposit or Withdraw?(d/w): ");
                        if (Console.ReadLine() == "d")
                        {
                            Console.Write("Enter Amount: ");
                            acc1.Deposit(int.Parse(Console.ReadLine()));
                        }
                        else if (Console.ReadLine() == "w")
                        {
                            Console.Write("Enter Amount: ");
                            acc1.Withdraw(int.Parse(Console.ReadLine()));
                        }
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }

            }
            while (true);
        }
    }


}
