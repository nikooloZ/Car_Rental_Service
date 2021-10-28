using AutoCenterV1.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoCenterV1
{
    public class MyDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderComment> Comments { get; set; }
        public DbSet<OrderCommit> Commits { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server = .\SQLEXPRESS; Database = AutoService; integrated security = true;");
        }
    }
}
