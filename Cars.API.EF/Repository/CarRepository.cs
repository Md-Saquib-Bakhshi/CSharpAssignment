using Cars.API.EF.Data;
using Cars.API.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Cars.API.EF.Repository
{
    public class CarRepository : ICarRepository
    {
        CarDBContext _carDBContext;

        public CarRepository(CarDBContext carDBContext)
        {
            _carDBContext = carDBContext;
        }

        public async Task<bool> AddCar(Car car)
        {
            _carDBContext.CarSet.Add(car);
            await _carDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCar(Guid id)
        {
            var isExistCar = await _carDBContext.CarSet.FirstOrDefaultAsync(x => x.Id == id);
            if(isExistCar != null)
            {
                _carDBContext.CarSet.Remove(isExistCar);
                await _carDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Car>> GetCars()
        {
            var getCars = await _carDBContext.CarSet.ToListAsync();
            return getCars;
        }

        public async Task<bool> UpdateCar(Guid id, Car car)
        {
            var isExistCar = await _carDBContext.CarSet.FirstOrDefaultAsync(x => x.Id == id);
            if (isExistCar != null)
            {
                isExistCar.Name = car.Name;
                isExistCar.Category = car.Category;
                isExistCar.Price = car.Price;
                await _carDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
