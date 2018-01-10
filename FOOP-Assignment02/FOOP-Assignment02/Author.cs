using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOP_Assignment02
{
    class Author : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Book[] Collection { get; set; }

        //IComparable implementation to sort authors by last name
        public int CompareTo(object obj)
        {
            Author tempAuthor = (Author)obj;
            int returnVal = this.LastName.CompareTo(tempAuthor.LastName);
            return returnVal;
        }

        public override string ToString()
        {
            return String.Format("{0},{1}",LastName,FirstName);
        }
    }
}
