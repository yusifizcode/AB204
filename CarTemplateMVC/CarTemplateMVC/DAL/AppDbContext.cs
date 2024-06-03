using CarTemplateMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CarTemplateMVC.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
