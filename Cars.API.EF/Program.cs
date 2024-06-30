using Cars.API.EF.Data;
using Cars.API.EF.Repository;
using Microsoft.EntityFrameworkCore;

namespace Cars.API.EF
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
                options.UseInMemoryDatabase("CarDB");
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
