using CarTemplateMVC.DAL;
using Microsoft.EntityFrameworkCore;

namespace CarTemplateMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-L6JGBQE\\SQLEXPRESS;Database=CarsDbAB204;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=true;");
            });

            var app = builder.Build();

            app.UseStaticFiles();
            //app.MapGet("/", () => "Hello World!");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}"
                );

            app.Run();
        }
    }
}
