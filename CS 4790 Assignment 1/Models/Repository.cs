using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_4790_Assignment_1.Models
{
    public static class Repository
    {
        private static List<InventoryItem> inventoryItems { get; set; }
        public static IEnumerable<InventoryItem> InventoryItems
        {
            get
            {
                return inventoryItems;
            }
        }

        public static void AddInventoryItem(InventoryItem item)
        {
            inventoryItems.Add(item);
        }
    }
}
