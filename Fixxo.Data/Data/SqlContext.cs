using Fixxo.Data.Entities;
using Fixxo.Data.Entities.ShoesEntities;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.Data.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<CatalogItemEntity>? CatalogItems { get; set; }
        public DbSet<JacketEntity>? Jackets { get; set; }
        public DbSet<ShoesEntity>? Shoes { get; set; }
        public DbSet<BootsEntity> Boots { get; set; }
        public DbSet<HighHeelsEntity> HighHeels { get; set; }


        // Jag ville egentligen ha sparat in ProductEntity och lagt som IProductInCatalog på CatalogItemENtity. Sen tänker jag att jag hade kunat jobba med nån slags IDesciption
        // på Product, för att kunna ha med olika beskrivningar, men jag fick inte till den biten med ef core och hinner nog inte göra om till ren nosql.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JacketEntity>()
                .HasOne(j => j.CatalogItem)
                .WithMany(c => c.Jackets)
                .HasForeignKey( j => j.CatalogItemId);

            modelBuilder.Entity<ShoesEntity>()
                .HasOne(c => c.CatalogItem)
                .WithMany(s => s.Shoes)
                .HasForeignKey(c => c.CatalogItemId);

            modelBuilder.Entity<BootsEntity>().Property(b => b.Season).HasConversion<string>();
        }
    }
}
