using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product_Income> Product_Incomes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (LocalDB)\\MSSQLLocalDB; Database = InventoryDB;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                        .HasMany(c => c.products)
                        .WithOne(c => c.Category)
                        .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<Product>()
                        .HasMany(c => c.Income_Products)
                        .WithOne(c => c.Product)
                        .HasForeignKey(c => c.ProductId);

            Admin admin = new()
            {
                Id = 1,
                FullName = "Super Admin",
                PhoneNumber = "998977656765",
                Password = "Admin.123$"
            };

            modelBuilder.Entity<Admin>()
                        .HasData(admin);



            base.OnModelCreating(modelBuilder);
        }
    }
}
