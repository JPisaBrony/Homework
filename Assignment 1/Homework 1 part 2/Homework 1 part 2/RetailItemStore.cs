using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_2
{
    class RetailItemStore
    {
        // static list used for storing RetailItem objects
        private static List<RetailItem> items = new List<RetailItem>();

        // this method add items to the private list
        public static void AddItem(RetailItem item)
        {
            // adds items to list
            items.Add(item);
        }

        // this method gets the whole list for reading
        public static List<RetailItem> getItems()
        {
            // returns list "items"
            return items;
        }

    }
}
