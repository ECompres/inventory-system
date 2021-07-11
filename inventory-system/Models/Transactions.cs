using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_system.Models
{
    public class Transactions
    {
        public int Id { get; set; }
        public string Transaction_type { get; set; }
        public int Article_id { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
    }
}
