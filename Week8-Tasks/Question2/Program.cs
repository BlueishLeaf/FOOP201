using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8pt2
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double BalanceDue { get; set; }

        public Customer(int id,string name, double balanceDue)
        {
            ID = id;
            Name = name;
            BalanceDue = balanceDue;
        }

        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}",ID,Name,BalanceDue);
        }
    }

    class CreditCustomer : Customer
    {
        public double InterestRate { get; set; }
        public CreditCustomer(double interestRate) : base(1234, "john", 4000)
        {
            InterestRate = interestRate;
        }
        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}",ID,Name,BalanceDue,InterestRate);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer Details");
            Console.Write("ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Balance Due : ");
            double balanceDue = double.Parse(Console.ReadLine());
            Customer cust1 = new Customer(id,name,balanceDue);
            Console.WriteLine(cust1.ToString());

            CreditCustomer[] creditArray = new CreditCustomer[5];
            for (int i=0;i<creditArray.Length;i++)
            {
                Console.Write("Enter credit rating : ");
                creditArray[i] = new CreditCustomer(double.Parse(Console.ReadLine()));

            }

            for (int i=0;i<creditArray.Length;i++)
            {
                Console.WriteLine(creditArray[i].ToString());
            }


        }
    }
}
