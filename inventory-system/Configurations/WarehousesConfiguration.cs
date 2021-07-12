using inventory_system.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_system.Configurations
{
    public class WarehousesConfiguration : IEntityTypeConfiguration<Warehouses>
    {
        public void Configure(EntityTypeBuilder<Warehouses> builder)
        {
            builder.HasKey(a => a.Id);
        }
    }
}
