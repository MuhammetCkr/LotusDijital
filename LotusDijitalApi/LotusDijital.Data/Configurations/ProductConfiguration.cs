using LotusDijital.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(p => p.ImageGalleries)
                .WithOne(ig => ig.Product)
                .HasForeignKey(ig => ig.ProductId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(p => p.VideoGalleries)
                .WithOne(vg => vg.Product)
                .HasForeignKey(vg => vg.ProductId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(p => p.DocumentGalleries)
                .WithOne(dg => dg.Product)
                .HasForeignKey(dg => dg.ProductId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
