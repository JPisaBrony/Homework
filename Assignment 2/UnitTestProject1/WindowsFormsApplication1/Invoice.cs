using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Invoice
    {
        // address object
        private Address address;
        // list item object
        private LineItem lineitem;

        public Invoice(LineItem ln, Address ad)
        {
            address = ad;
            lineitem = ln;
        }

        // calulates the total amount for each item
        // accepts an index
        public decimal getItemTotal(int i)
        {
            // returns the amount times the quantity so that
            // we get the total amount at the given index
            return lineitem.getProductAtIndex(i).Amount * lineitem.getProductAtIndex(i).Quantity;
        }

        // calculates the total for all the items
        public decimal grandTotal()
        {
            // total amount
            decimal total = 0;
            // iterates through each product in the list of line items
            foreach (Product p in lineitem.getProducts())
            {
                // adds up the total by multiplying each item
                // by the amount and the quantity
                // and storing it in the total variable
                total += p.Amount * p.Quantity;
            }
            return total;
        }

        // this method gets the list of products
        public List<Product> getLineItem()
        {
            return lineitem.getProducts();
        }

        // this method get the address object
        // except it returns the toString of the object
        public string getAddress()
        {
            return address.ToString();
        }
    }
}
