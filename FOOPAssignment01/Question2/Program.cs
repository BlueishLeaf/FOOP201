using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOPAssignmentPt2
{
    class MemberTest
    {
        //Calls ToString method in Member class for each object in the
        //member array, outputs all their details
        public void PrintDetails(Member[] memberArray)
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}","First Name","Last Name","Age","Member ID","Membership","Price");
            for (int i=0;i<memberArray.Length;i++)
            {
                Console.WriteLine(memberArray[i].ToString());
            }
        }
    }

    class Member : IComparable
    {
        public static int numMembers = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int MemberID { get; set; }
        public string MembershipStatus { get; set; }
        public double Price { get; }

        public Member(string firstName, string lastName, int age, int memberId)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            MemberID = memberId;
            MembershipStatus = "Expired";
            Price = SetPrice();
            numMembers++;
        }

        //Overrides ToString() method and instead returns a formatted string of member details
        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}",FirstName,LastName,Age,MemberID,MembershipStatus,Price);
        }

        //Inverts the membership status of the member this method is called on
        public void ChangeStatus()
        {
            if (MembershipStatus=="Expired")
            {
                MembershipStatus = "Current";
            }
            else if (MembershipStatus=="Current")
            {
                MembershipStatus = "Expired";
            }
        }

        //Sets the price of the readonly property "Price" depending on member age
        private double SetPrice()
        {
            if (Age < 18)
            {
                return 50;
            }
            else if (Age>=18)
            {
                return 150;
            }
            return 0;

        }

        //Compares each member's last name, for sorting purposes
        public int CompareTo(object obj)
        {
            Member tempMember = (Member)obj;
            int returnVal = this.LastName.CompareTo(tempMember.LastName);
            return returnVal;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Array of members is declared
            Member[] memberArray = new Member[5];
            memberArray[0] = new Member("Killian","Kelly",17,1234);
            memberArray[1] = new Member("John", "Carmac", 47, 1235);
            memberArray[2] = new Member("John", "Romero", 43, 1236);
            memberArray[3] = new Member("Dara", "MacConville", 17, 1237);
            memberArray[4] = new Member("Ryan", "Letourneu", 28, 1238);

            //Prints out details of members as they are in the beginning
            Console.WriteLine("====CLUB MEMBERSHIP DETAILS====");
            Console.WriteLine("====Member Details====");
            MemberTest newTest = new MemberTest();
            newTest.PrintDetails(memberArray);
            Console.WriteLine();

            //Change status of 1st and 3rd member in array, then prints out the details again
            memberArray[0].ChangeStatus();
            memberArray[2].ChangeStatus();
            Console.WriteLine("====Member Details With Status Changed On 1 & 3====");
            newTest.PrintDetails(memberArray);
            Console.WriteLine();

            //Accesses the static variable in the member class that keeps track of the number
            //of instances of that class and prints it out
            Console.WriteLine("Number of members: "+Member.numMembers);
            Console.WriteLine();

            //Sorts array alphabetically by surname using IComparable, REVERSES it, then prints out the sorted members in reverse alphabetical order
            Array.Sort(memberArray);
            Array.Reverse(memberArray);
            Console.WriteLine("====Member Details After Sorting By Surname====");
            newTest.PrintDetails(memberArray);


        }
    }
}
