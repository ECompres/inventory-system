using inventory_system.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_system.Configurations
{
    public class ArticlesConfiguration:IEntityTypeConfiguration<Articles>
    {
        public void Configure(EntityTypeBuilder<Articles> builder)
        {
            builder.ToTable("Articles");

            builder.HasKey(a => a.Id);

            builder.HasOne(a => a.InventoryType)
                   .WithMany(b => b.Articles)
                   .HasForeignKey(fk => fk.InventoryTypeId);
        }
    }
}