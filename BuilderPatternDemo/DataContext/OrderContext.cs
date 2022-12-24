using BuilderPatternDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace BuilderPatternDemo.DataContext;

public class OrderContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
}