using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CS_4790_Assignment_2.Models
{
    public class InventoryItem
    {
        public long Id { get; set; }
        public string Description { get; set; }
        [DisplayName("Number in Stock")]
        public int? NumInStock { get; set; }
        public decimal? Price { get; set; }
    }
}
