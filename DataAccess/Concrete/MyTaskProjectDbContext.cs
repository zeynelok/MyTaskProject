using DataAccess.Concrete.Mappings;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.DataAccess.Concrete.Seeds;

namespace DataAccess.Concrete
{
    public class MyTaskProjectDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyTaskProjectDb;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());

            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2, 3 }));
            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1, 2, 3,4,5,6,7,8,9 }));
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
       

    }
}
