using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_system.Models
{
    public class Inventory_Type
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Accounting_account { get; set; }
        public bool Status { get; set; }
    }
}
