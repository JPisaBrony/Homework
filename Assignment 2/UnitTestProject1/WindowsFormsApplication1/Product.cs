using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Product
    {
        private decimal amount;
        private string description;
        private int quantity;

        public decimal Amount
        {
            get
            {
                return amount;   
            }
            set
            {
                amount = Amount;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = Description;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = Quantity;
            }
        }

        public Product(string a, decimal d, int n)
        {
            description = a;
            amount = d;
            quantity = n;
        }

        public override string ToString()
        {
            return "Description: " + description + " Amount: " + amount + " Quantity: " + quantity;
        }

    }
}
