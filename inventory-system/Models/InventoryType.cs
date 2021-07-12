using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_system.Models
{
    public class InventoryType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string AccountingAccount { get; set; }
        public bool Status { get; set; }
        public int ArticleRef { get; set; }
        public List<Articles> Articles { get; set; }
    }
}
