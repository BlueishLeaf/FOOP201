using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4pt2
{
    class School : IComparable
    {
        public string name { get; set; }
        public int numStudents { get; set; }

        public School(string name, int numStudents)
        {
            this.name = name;
            this.numStudents = numStudents;
        }

        public int CompareTo(object obj)
        {
            int returnValue;
            School tempSchool = (School)obj;
            if (this.numStudents > tempSchool.numStudents)
            {
                returnValue = 1;
            }
            else if (this.numStudents < tempSchool.numStudents)
            {
                returnValue = -1;
            }
            else
            {
                returnValue = 0;
            }
            return returnValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            School[] schoolArray= new School[5];
            for (int i=0;i<5;i++)
            {
                schoolArray[i]=new School(Console.ReadLine(),int.Parse(Console.ReadLine()));
            }
            Array.Sort(schoolArray);
            Console.WriteLine("enter min enrollment");
            int minRoll = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (schoolArray[i].numStudents >= minRoll)
                {
                    Console.WriteLine(schoolArray[i].numStudents);
                }
            }

        }
    }
}
