using Cars.API.Data;
using Cars.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cars.API.Repository
{
    public class CarRepository : ICarRepository
    {
        CarDBContext _carDBContext;

        public CarRepository(CarDBContext carDBContext)
        {
            _carDBContext = carDBContext;
        }

        //Create logic
        public async Task<bool> AddCar(Car car)
        {
            _carDBContext.CarSet.Add(car);
            await _carDBContext.SaveChangesAsync();
            return true;
        }

        //Read logic
        public async Task<IEnumerable<Car>> GetCars()
        {
            var allCars = await _carDBContext.CarSet.ToListAsync();
            return allCars;
        }

        //Update logic
        public async Task<bool> UpdateCar(Guid id, Car car)
        {
            var isExistedCar = await _carDBContext.CarSet.FirstOrDefaultAsync(x => x.Id == id);
            if(isExistedCar != null)
            {
                isExistedCar.Name = car.Name;
                isExistedCar.Category = car.Category;
                isExistedCar.Price = car.Price;
                await _carDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        //Delete logic
        public async Task<bool> DeleteCar(Guid id)
        {
            var isExistedCar = await _carDBContext.CarSet.FirstOrDefaultAsync(x => x.Id == id);
            if(isExistedCar != null)
            {
                _carDBContext.CarSet.Remove(isExistedCar);
                await _carDBContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
