using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_3
{
    class PersonEntry
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public PersonEntry(string n, string e, string p)
        {
            Name = n;
            Email = e;
            PhoneNumber = p;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Email: " + Email + " Phone Number: " + PhoneNumber;
        }

    }
}
