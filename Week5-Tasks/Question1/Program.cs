using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Friend : IComparable
    {
        public string name { get; set; }
        public int phone { get; set; }
        public int birthdayDay { get; set; }
        public int birthdayMonth { get; set; }
        public int birthdayYear { get; set; }


        public Friend(string name, int phone, int birthdayDay, int birthdayMonth, int birthdayYear)
        {
            this.name = name;
            this.phone = phone;
            this.birthdayDay = birthdayDay;
            this.birthdayMonth = birthdayMonth;
            this.birthdayYear = birthdayYear;
        }

        public int CompareTo(object obj)
        {
            Friend tempFriend = (Friend)obj;
            int returnVal = this.name.CompareTo(tempFriend.name);
            return returnVal;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which program do you want to run?");
            Console.WriteLine("1. FriendList");
            Console.WriteLine("2. FriendBirthday");
            Console.WriteLine("3. AllFriendsInSameMonth");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    FriendList();
                    break;

                case 2:
                    FriendBirthday();
                    break;

                case 3:
                    AllFriendsInSameMonth();
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }

        }

        static void FriendList()
        {
            Friend[] FriendArray = new Friend[3];
            for (int i = 0; i < FriendArray.Length; i++)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter phone number: ");
                int phone = int.Parse(Console.ReadLine());
                Console.Write("Enter birthday day: ");
                int birthdayDay = int.Parse(Console.ReadLine());
                Console.Write("Enter birthday month: ");
                int birthdayMonth = int.Parse(Console.ReadLine());
                Console.Write("Enter birthday year: ");
                int birthdayYear = int.Parse(Console.ReadLine());


                FriendArray[i]=new Friend(name,phone,birthdayDay,birthdayMonth,birthdayYear);
            }
            Array.Sort(FriendArray);
            foreach (Friend t in FriendArray)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",t.name, t.phone, t.birthdayDay, t.birthdayMonth, t.birthdayYear);
            }
        }

        static void FriendBirthday()
        {
            Friend[] FriendArray = new Friend[3];
            for (int i = 0; i < FriendArray.Length; i++)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter phone number: ");
                int phone = int.Parse(Console.ReadLine());
                Console.Write("Enter birthday day: ");
                int birthdayDay = int.Parse(Console.ReadLine());
                Console.Write("Enter birthday month: ");
                int birthdayMonth = int.Parse(Console.ReadLine());
                Console.Write("Enter birthday year: ");
                int birthdayYear = int.Parse(Console.ReadLine());


                FriendArray[i] = new Friend(name, phone, birthdayDay, birthdayMonth, birthdayYear);
            }
            Array.Sort(FriendArray);
            foreach (Friend t in FriendArray)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", t.name, t.phone, t.birthdayDay, t.birthdayMonth, t.birthdayYear);
            }

            Console.Write("Enter name of friend to search: ");
            string query = Console.ReadLine();
            foreach (Friend t in FriendArray)
            {
                if (t.name == query)
                {
                    Console.WriteLine("Your friend's phone number is {0}. His/Her birthday is {1} {2} {3}",t.phone,t.birthdayDay,t.birthdayMonth,t.birthdayYear);
                }
            }
        }

        static void AllFriendsInSameMonth()
        {
            Friend[] FriendArray = new Friend[3];
            for (int i = 0; i < FriendArray.Length; i++)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter phone number: ");
                int phone = int.Parse(Console.ReadLine());
                Console.Write("Enter birthday day: ");
                int birthdayDay = int.Parse(Console.ReadLine());
                Console.Write("Enter birthday month: ");
                int birthdayMonth = int.Parse(Console.ReadLine());
                Console.Write("Enter birthday year: ");
                int birthdayYear = int.Parse(Console.ReadLine());


                FriendArray[i] = new Friend(name, phone, birthdayDay, birthdayMonth, birthdayYear);
            }
            Array.Sort(FriendArray);
            foreach (Friend t in FriendArray)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", t.name, t.phone, t.birthdayDay, t.birthdayMonth, t.birthdayYear);
            }

            Console.Write("Enter name of friend to search: ");
            string query = Console.ReadLine();
            foreach (Friend t in FriendArray)
            {
                if (t.name == query)
                {
                    Console.WriteLine("Your friend's phone number is {0}. His/Her birthday is {1} {2} {3}", t.phone, t.birthdayDay, t.birthdayMonth, t.birthdayYear);
                    foreach (Friend t1 in FriendArray)
                    {
                        if (t.birthdayMonth == t1.birthdayMonth)
                        {
                            Console.WriteLine("{0} has the same birth month as your searched friend.",t1.name);
                        }
                    }
                }
            }
        }
    }
}
