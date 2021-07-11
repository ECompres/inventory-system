using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_system.Models
{
    public class Accounting_Entries
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Inventory_Type_Id { get; set; }
        public string Accounting_Account { get; set; }
        public string Movement_Type { get; set; }
        public DateTime Entry_Date { get; set; }
        public double Entry_Amount { get; set; }
        public bool Status { get; set; }
    }
}
