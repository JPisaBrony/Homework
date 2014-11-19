using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Invoice Application written by
// Josh Pohl and Matt Leet

namespace WindowsFormsApplication1
{
    public class Product
    {
        // class properties
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public Product(string a, decimal d, int n)
        {
            Description = a;
            Amount = d;
            Quantity = n;
        }

        // formats the toString so that we can get
        // information about each product
        public override string ToString()
        {
            return "Description: " + Description + " Amount: " + Amount + " Quantity: " + Quantity;
        }

    }
}
