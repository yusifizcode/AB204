using FirstApiProject.Configurations;
using FirstApiProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApiProject.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
