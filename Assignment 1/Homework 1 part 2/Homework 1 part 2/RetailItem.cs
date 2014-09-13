using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_2
{
    class RetailItem
    {
        // this property holds a breif description about the item
        public string Description { get; set; }
        // this property holds tells how many of that item are on hand
        public int UnitsOnHand { get; set; }
        // this property holds the price of the item
        public decimal Price { get; set; }
        
        // constructor
        // accepts a string for the description, an int for the units, and a decimal for the price
        public RetailItem(string d, int u, decimal p)
        {
            // sets the Description
            Description = d;
            // sets the UnitsOnHand
            UnitsOnHand = u;
            // sets the Price
            Price = p;
        }

        // overriden toString Method
        // this method is responsible for outputing the information in each of the properties
        public override string ToString()
        {
            // returns the Description, the UnitsOnHand, and the Price in one string
            return "Description: " + Description + " UnitsOnHand: " + UnitsOnHand + " Price: " + Price.ToString("C");
        }

    }
}
