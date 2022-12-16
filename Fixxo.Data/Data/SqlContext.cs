using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixxo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.Data.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<CatalogItemEntity> CatalogItems { get; set; }
        public DbSet<JacketEntity> Jackets { get; set; }
        public DbSet<ShoesEntity> Shoes { get; set; }

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
        }
    }
}
