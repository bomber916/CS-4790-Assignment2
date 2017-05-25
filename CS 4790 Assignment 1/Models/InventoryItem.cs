using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_4790_Assignment_1.Models
{
    public class InventoryItem
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public int? NumInStock { get; set; }
        public decimal? Price { get; set; }
    }
}
