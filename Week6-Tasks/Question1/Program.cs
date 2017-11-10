using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    class Bill
    {
        public string CompanyName { get; set; }
        public int AmountOwed { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}",GetType().ToString(),CompanyName,AmountOwed);
        }

    }

    class OverdueBill : Bill
    {
        public int DaysOverdue { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Bill bill1 = new Bill();
            OverdueBill lateBill1 = new OverdueBill();

            bill1.CompanyName = "Corp1";
            bill1.AmountOwed = 20500;
            lateBill1.CompanyName = "Corp2";
            lateBill1.AmountOwed = 39500;
            lateBill1.DaysOverdue = 50;

            Console.WriteLine(bill1.ToString());

        }
    }
}
