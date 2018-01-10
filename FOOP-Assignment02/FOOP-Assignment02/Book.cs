using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOOP_Assignment02
{
    class Book
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set; }
        public override string ToString()
        {
            return String.Format("{0}, {1} pages - {2:C2}", Title, Pages, Price);
        }
    }
}
