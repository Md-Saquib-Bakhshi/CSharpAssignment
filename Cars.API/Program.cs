using Cars.API.Data;
using Cars.API.Repository;
using Microsoft.EntityFrameworkCore;

namespace Cars.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddScoped<ICarRepository, CarRepository>();

            builder.Services.AddDbContext<CarDBContext>(options =>
            {
                var connectionString = builder.Configuration.GetConnectionString("CarConnectionString");
                options.UseSqlServer(connectionString);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
