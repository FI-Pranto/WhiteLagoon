using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Web.Data;
using WhiteLagoon.Web.Repository;
using WhiteLagoon.Web.Repository.IRepository;
using WhiteLagoon.Web.Service;
using WhiteLagoon.Web.Service.IService;

namespace WhiteLagoon.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")
                ));

            //repo
            builder.Services.AddScoped<IVillaRepository,VillaRepository>();

            //services
            builder.Services.AddScoped<IVillaService,VillaService>();

            //UOF
            builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
