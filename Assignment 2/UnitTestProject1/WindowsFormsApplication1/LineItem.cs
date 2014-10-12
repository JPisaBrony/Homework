using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class LineItem
    {
        private List<Product> list = new List<Product>();
        private string description;

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

        public void addItem(Product p)
        {
            list.Add(p);
        }

        public List<Product> getProducts()
        {
            return list;
        }

        public List<Product> getList()
        {
            return list;
        }

        public Product getProductAtIndex(int i)
        {
            return list[i];
        }

        public void removeAtIndex(int i)
        {
            list.RemoveAt(i);
        }

    }
}
