using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_system.Models
{
    public class AccountingEntries
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int InventoryTypeId { get; set; }
        public InventoryType InventoryType { get; set; }
        public string AccountingAccount { get; set; }
        public string MovementType { get; set; }
        public DateTime EntryDate { get; set; }
        public double EntryAmount { get; set; }
        public bool Status { get; set; }
    }
}
