using inventory_system.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_system.Configurations
{
    public class TransactionsConfiguration:IEntityTypeConfiguration<Transactions>
    {
        public void Configure(EntityTypeBuilder<Transactions> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Date).HasDefaultValueSql("GETDATE()");
        }
    }
}
