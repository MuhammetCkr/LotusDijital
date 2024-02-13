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
    public class InnerPageConfiguration : IEntityTypeConfiguration<InnerPage>
    {
        public void Configure(EntityTypeBuilder<InnerPage> builder)
        {
            builder.HasMany(i => i.ImageGalleries)
                .WithOne(ig => ig.InnerPage)
                .HasForeignKey(ig => ig.InnerPageId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(p => p.VideoGalleries)
                .WithOne(vg => vg.InnerPage)
                .HasForeignKey(vg => vg.InnerPageId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(p => p.DocumentGalleries)
                .WithOne(dg => dg.InnerPage)
                .HasForeignKey(dg => dg.InnerPageId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
