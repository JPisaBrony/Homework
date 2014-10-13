using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class LineItem
    {
        // list of products
        private List<Product> list = new List<Product>();

        // class properties
        public string Description { get; set; }

        // adds a product to the list
        public void addItem(Product p)
        {
            list.Add(p);
        }

        // get the product list
        public List<Product> getProducts()
        {
            return list;
        }

        // gets the product at a certain index
        public Product getProductAtIndex(int i)
        {
            return list[i];
        }

        // removes a product at the given index
        public void removeAtIndex(int i)
        {
            list.RemoveAt(i);
        }

    }
}
