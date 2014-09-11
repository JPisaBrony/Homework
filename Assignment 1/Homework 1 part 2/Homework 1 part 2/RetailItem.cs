using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_2
{
    class RetailItem
    {
        public string Description { get; set; }
        public int UnitsOnHand { get; set; }
        public int Price { get; set; }

        public RetailItem(string d, int u, int p)
        {
            Description = d;
            UnitsOnHand = u;
            Price = p;
        }

        public override string ToString()
        {
            return "Description: " + Description + " UnitsOnHand: " + UnitsOnHand + " Price: " + Price;
        }

    }
}
