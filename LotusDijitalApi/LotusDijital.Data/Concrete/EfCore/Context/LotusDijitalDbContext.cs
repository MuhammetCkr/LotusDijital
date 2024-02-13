using LotusDijital.Data.Configurations;
using LotusDijital.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LotusDijital.Data.Concrete.EfCore.Context
{
    public class LotusDijitalDbContext : IdentityDbContext<User>
    {
        public LotusDijitalDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<DocumentGallery> DocumentGalleries { get; set; }
        public DbSet<ImageGallery> ImageGalleries { get; set; }
        public DbSet<InnerPage> InnerPages { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<VideoGallery> VideoGalleries { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Eyyyy EF Core! Git bu uygulamadaki configuration dosyalarını işle!
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
