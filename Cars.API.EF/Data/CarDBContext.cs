using Microsoft.EntityFrameworkCore;
using Cars.API.EF.Models;

namespace Cars.API.EF.Data
{
    public class CarDBContext : DbContext
    {
        public CarDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Car> CarSet { get; set; }
    }
}
