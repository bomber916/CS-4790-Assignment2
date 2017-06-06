using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_4790_Assignment_2.Models
{
    public static class Repository
    {
        private static List<InventoryItem> inventoryItems { get; set; }
        private static long nextId { get; set; }
        public static IEnumerable<InventoryItem> InventoryItems
        {
            get
            {
                if(inventoryItems == null)
                {
                    inventoryItems = new List<InventoryItem>();
                }
                return inventoryItems;
            }
        }

        public static void AddInventoryItem(InventoryItem item)
        {
            if(nextId == 0)
            {
                nextId = InventoryItems.Count() + 1;
            }
            item.Id = nextId;

            if (inventoryItems == null)
            {
                inventoryItems = new List<InventoryItem>();
            }
            inventoryItems.Add(item);
            nextId++;
        }
    }
}
