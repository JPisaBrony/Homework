using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Invoice
    {
        private Address address;
        private LineItem lineitem;

        public Invoice(LineItem ln, Address ad)
        {
            address = ad;
            lineitem = ln;
        }

        public decimal getItemTotal(int i)
        {
            return lineitem.getProductAtIndex(i).Amount * lineitem.getProductAtIndex(i).Quantity;
        }

        public decimal grandTotal()
        {
            decimal total = 0;
            foreach (Product p in lineitem.getProducts())
            {
                total += p.Amount * p.Quantity;
            }
            return total;
        }

        public List<Product> getLineItem()
        {
            return lineitem.getProducts();
        }

        public string getAddress()
        {
            return address.ToString();
        }
    }
}
