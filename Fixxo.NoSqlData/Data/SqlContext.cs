using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixxo.Core.Models;
using Fixxo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fixxo.Data.Data
{
    public class NoSqlContext : DbContext
    {
        public NoSqlContext(DbContextOptions<NoSqlContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>().ToContainer("Products").HasPartitionKey(x => x.Id);
        }
    }
}
