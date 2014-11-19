<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Invoice Application written by
// Josh Pohl and Matt Leet

namespace WindowsFormsApplication1
{
    public class Address
    {
        // class properties
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Address(string n, string s, string c, string z, string t, string u)
        {
            Name = n;
            Street = s;
            City = c;
            ZipCode = z;
            State = t;
            Country = u;
        }

        // overriden toString to format the string so that it looks
        // more like an address
        public override string ToString()
        {
            return Name + "\r\n" + Street + "\r\n" + City + ", " + State + " " + ZipCode + "\r\n" + Country;
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Invoice Application written by
// Josh Pohl and Matt Leet

namespace WindowsFormsApplication1
{
    public class Address
    {
        // class properties
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Address(string n, string s, string c, string z, string t, string u)
        {
            Name = n;
            Street = s;
            City = c;
            ZipCode = z;
            State = t;
            Country = u;
        }

        // overriden toString to format the string so that it looks
        // more like an address
        public override string ToString()
        {
            return Name + "\r\n" + Street + "\r\n" + City + ", " + State + " " + ZipCode + "\r\n" + Country;
        }

    }
}
>>>>>>> c9b649ab51856c9e14811ac262c7fe7311173c36
