using ConputerShopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ConputerShopAPI.Data
{
    public class ManagerDbContext :DbContext
    {
        public ManagerDbContext(DbContextOptions<ManagerDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
