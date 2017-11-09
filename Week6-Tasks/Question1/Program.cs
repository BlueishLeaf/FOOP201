using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
    class Bill
    {
        public string companyName { get; set; }
        public int amountOwed { get; set; }

        public Bill(string companyName, int amountOwed)
        {
            this.companyName = companyName;
            this.amountOwed = amountOwed;
            Console.WriteLine(ToString());
            Console.WriteLine(companyName);
            Console.WriteLine(amountOwed);
        }
        public override string ToString()
        {
            string type = GetType().ToString();
            return type;
        }

    }

    class OverdueBill : Bill
    {
        public int daysOverdue { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bill bill1 = new Bill("Mary",50000);
            OverdueBill lateBill1 = new OverdueBill();
        }
    }
}
