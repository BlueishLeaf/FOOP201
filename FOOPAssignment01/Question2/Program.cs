using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOPAssignment02
{
    class Employee : IComparable
    {
        public static int employeeCount;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }
        private double salary;
        private double holidaysLeft = 30;
        private int numHolidays = 0;
        public double Salary
        {
            get
            {
                return salary;
            }
        }
        public string Department { get; set; }

        private Holiday[] HolidayList = new Holiday[10];

        public Employee(string firstName, string lastName, int employeeId, double salary, string department)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmployeeId = employeeId;
            this.salary = salary;
            this.Department = department;
            employeeCount++;

        }

        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,10}{3,10}{4,15}",FirstName,LastName,EmployeeId,Salary,Department);
        }

        public void PayRise(double payIncrease)
        {
            salary = Salary * payIncrease;
        }

        public int CompareTo(object obj)
        {
            Employee tempEmployee = (Employee)obj;
            int returnVal= this.LastName.CompareTo(tempEmployee.LastName);
            return returnVal;
        }

        public void AddHoliday(DateTime startDate, DateTime endDate)
        {
            HolidayList[numHolidays] = new Holiday(startDate,endDate);
            this.holidaysLeft -= HolidayList[numHolidays].GetDays();
            Console.WriteLine("You have "+holidaysLeft + " holidays remaining.");
            numHolidays++;
        }

    }

    class Holiday
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Holiday(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public double GetDays()
        {
            return (EndDate - StartDate).TotalDays;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] empArray = new Employee[4];
            empArray[0] = new Employee("John","Smith", 1234, 50000, "Accounting");
            empArray[1] = new Employee("John", "Carmac", 4321, 70000, "IT");
            empArray[2] = new Employee("John", "Romero", 6969, 100000, "IT");
            empArray[3] = new Employee("John", "Johnston", 8033, 20000, "Janitorial");
            for (int i=0;i<empArray.Length;i++)
            {
                Console.WriteLine(empArray[i].ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Number of employees = "+Employee.employeeCount);
            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(empArray[i].ToString());
            }
            Console.WriteLine();
            Array.Sort(empArray);
            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(empArray[i].ToString());
            }
            Console.Write("Enter index of employee to add holiday to: ");
            int empIndex = int.Parse(Console.ReadLine());
            Console.Write("Enter the start date of your holiday: ");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter the end date of your holiday: ");
            DateTime endDate = Convert.ToDateTime(Console.ReadLine());
            empArray[empIndex].AddHoliday(startDate, endDate);
        }
    }
}
