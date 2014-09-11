using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_2
{
    class RetailItemStore
    {
        private static List<RetailItem> Items = new List<RetailItem>();

        public static void AddItem(RetailItem item)
        {
            Items.Add(item);
        }

        public static List<RetailItem> getItems()
        {
            return Items;
        }

    }
}
