using inventory_system.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_system.Configurations
{
    public class AccountingEntriesConfiguration:IEntityTypeConfiguration<AccountingEntries>
    {
        public void Configure(EntityTypeBuilder<AccountingEntries> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
