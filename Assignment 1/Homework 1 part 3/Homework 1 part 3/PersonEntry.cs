using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_3
{
    class PersonEntry
    {
        // name property for holding the name of the person
        public string Name { get; set; }
        // email property for holding the email of the person
        public string Email { get; set; }
        // phone number property for holding the phone number of the person
        public string PhoneNumber { get; set; }

        // constructor
        // accepts a three strings each for the name, email, and phone number
        public PersonEntry(string n, string e, string p)
        {
            // sets the name property
            Name = n;
            // sets the email property
            Email = e;
            // sets the phone number proprety
            PhoneNumber = p;
        }

        // overriden toString method
        // this method displays the name, email, and phone number of the person
        public override string ToString()
        {
            // returns the name, email, and phone number in one stringx
            return "Name: " + Name + " Email: " + Email + " Phone Number: " + PhoneNumber;
        }

    }
}
