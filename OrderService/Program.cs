using Microsoft.EntityFrameworkCore;
using OrderService.Business;
using OrderService.Business.Interfaces;
using OrderService.Data;
using OrderService.Data.Interfaces;
using OrderService.Mappers;
using OrderService.Mappers.Interfaces;
using OrderService.Provider;

namespace OrderService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json")
              .Build();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddMvc(options =>
            {
                options.SuppressAsyncSuffixInActionNames = false;
            });

            builder.Services.AddTransient<ICreateOrderCommand, CreateOrderCommand>();

            builder.Services.AddTransient<IGetOrdersCommand, GetOrdersCommand>();

            builder.Services.AddTransient<IGetOrderCommand, GetOrderCommand>();

            builder.Services.AddTransient<IOrderRepository, OrderRepository>();

            builder.Services.AddTransient<IOrderResponseMapper, OrderResponseMapper>();

            builder.Services.AddTransient<IDbOrderMapper, DbOrderMapper>();

            var conn = configuration.GetConnectionString("DefaultDataBase");

            builder.Services.AddDbContext<OrdersDbContext>(o =>
            o.UseNpgsql(conn, assembly => assembly.MigrationsAssembly("OrderService.Provider")));

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<OrdersDbContext>();
                db.Database.Migrate();
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}");


            app.Run();
        }
    }
}