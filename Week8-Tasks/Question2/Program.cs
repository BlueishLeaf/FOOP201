using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8pt2
{
    class Customer : IComparable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double BalanceDue { get; set; }

        public int CompareTo(object obj)
        {
            Customer tempCustomer = (Customer)obj;
            return (ID.CompareTo(tempCustomer.ID));
        }

        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}",ID,Name,BalanceDue);
        }
    }

    class CreditCustomer : Customer
    {
        public double InterestRate { get; set; }
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
            Customer[] customerArray = new Customer[3];
            for(int i = 0; i < customerArray.Length; i++)
            {
                customerArray[i] = new Customer();
                Console.Write("ID : ");
                customerArray[i].ID = int.Parse(Console.ReadLine());
                Console.Write("Name : ");
                customerArray[i].Name = Console.ReadLine();
                Console.Write("Balance Due : ");
                customerArray[i].BalanceDue = double.Parse(Console.ReadLine());
            }
            Array.Sort(customerArray);
            for (int i=0;i<customerArray.Length;i++)
            {
                Console.WriteLine(customerArray[i].ToString());
            }

            Console.WriteLine("Enter Credit Customer Details");
            CreditCustomer[] creditCustomerArray = new CreditCustomer[3];
            for (int i = 0; i < creditCustomerArray.Length; i++)
            {
                creditCustomerArray[i] = new CreditCustomer();
                Console.Write("ID : ");
                creditCustomerArray[i].ID = int.Parse(Console.ReadLine());
                Console.Write("Name : ");
                creditCustomerArray[i].Name = Console.ReadLine();
                Console.Write("Balance Due : ");
                creditCustomerArray[i].BalanceDue = double.Parse(Console.ReadLine());
                Console.Write("Interest Rate : ");
                creditCustomerArray[i].InterestRate = double.Parse(Console.ReadLine());
            }
            Array.Sort(creditCustomerArray);
            for (int i = 0; i < creditCustomerArray.Length; i++)
            {
                Console.WriteLine(creditCustomerArray[i].ToString());
            }
        }
    }
}
