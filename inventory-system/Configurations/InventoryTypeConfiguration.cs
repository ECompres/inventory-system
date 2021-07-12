using inventory_system.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_system.Configurations
{
    public class InventoryTypeConfiguration:IEntityTypeConfiguration<InventoryType>
    {
        public void Configure(EntityTypeBuilder<InventoryType> builder)
        {
            builder.ToTable("InventoryType");

            builder.HasKey(a => a.Id);

            builder.HasMany(a => a.Articles)
                   .WithOne(b => b.InventoryType)
                   .HasForeignKey(fk => fk.InventoryTypeId);
        }
    }
}
