using Fixxo.Data.Entities;
using Fixxo.NoSqlData.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.NoSqlData.Data
{
    public class NoSqlContext : DbContext
    {
        public NoSqlContext(DbContextOptions<NoSqlContext> options) : base(options)
        {
        }

        // public DbSet<ProductEntity> Products { get; set; }
        // public DbSet<JacketEntity> Jackets { get; set; }
        // public DbSet<ShoesEntity> Shoes { get; set; }
        public DbSet<CatalogEntity> CatalogEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<ProductEntity>().ToContainer("Products").HasPartitionKey(x => x.Id);
            // modelBuilder.Entity<JacketEntity>().ToContainer("Products").HasPartitionKey(x => x.JacketId);
            // modelBuilder.Entity<ShoesEntity>().ToContainer("Products").HasPartitionKey(x => x.Id);
            modelBuilder.Entity<CatalogEntity>().ToContainer("Products").HasPartitionKey(x => x.Id);


            // modelBuilder.Entity<CatalogEntity>()
            //     .HasMany(h => (ICollection<JacketEntity>)h.Product)
            //     .WithOne()
            //     .HasForeignKey(p => p.Id);
            //
            // modelBuilder.Entity<CatalogEntity>()
            //     .HasMany(h => (ICollection<ShoesEntity>)h.Product)
            //     .WithOne()
            //     .HasForeignKey(p => p.Id);  
        }
    }
}
