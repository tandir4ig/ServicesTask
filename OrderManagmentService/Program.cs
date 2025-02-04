using Microsoft.EntityFrameworkCore;
using OrderManagmentService.Commands.Products.CreateProduct;
using ProductOrderService.Contexts;
using ProductOrderService.Services;
using ProductOrderService.Services.Interfaces;
using System.Net.NetworkInformation;

namespace OrderManagmentService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<IOrderRepository, OrderRepository>();

            builder.Services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddHttpClient();
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddAutoMapper(typeof(CreateProductMapping));

            builder.Services.AddApplication();

            //foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            //{
            //    builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));
            //}

            //builder.Services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowSpecificOrigin",
            //        builder => builder
            //            .WithOrigins("http://localhost:5027/swagger/index.html")
            //            .AllowAnyMethod()
            //            .AllowAnyHeader());
            //});

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseCors("AllowSpecificOrigin");

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
                db.Database.Migrate();
            }

            //app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
