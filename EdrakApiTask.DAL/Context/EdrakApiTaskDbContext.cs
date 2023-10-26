using EdrakApiTask.BL.Customers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace EdrakApiTask.DAL;

public class EdrakApiTaskDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Order> Categories => Set<Order>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderLineItem> OrderLineItems { get; set; }
    
    public EdrakApiTaskDbContext(DbContextOptions<EdrakApiTaskDbContext> options) : base(options) { }

}
