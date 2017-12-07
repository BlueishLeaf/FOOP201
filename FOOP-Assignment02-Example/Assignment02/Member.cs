using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Member
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int JoinYear { get; set; }
        public MembershipType MemType { get; set; }

        public override string ToString()
        {
            return String.Format(Name);
        }
    }

    class MembershipType
    {
        public string Type { get; set; }
    }
}
