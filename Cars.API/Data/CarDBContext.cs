using Microsoft.EntityFrameworkCore;
using Cars.API.Models;

namespace Cars.API.Data
{
    public class CarDBContext : DbContext
    {
        public CarDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Car> CarSet { get; set; }
    }
}
