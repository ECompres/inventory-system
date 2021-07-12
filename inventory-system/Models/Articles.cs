using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_system.Models
{
    public class Articles
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public int InventoryTypeId {get;set;}
        public InventoryType InventoryType { get; set; }
        public int UnitCost {get;set;}
        public string Condition { get; set; }
    }
}
