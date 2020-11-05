using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductsApi.Data;
using ProductsApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions optionsBuilder): base(optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<Product> Products { get; set; }
    }
}
