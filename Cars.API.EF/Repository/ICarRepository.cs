using Cars.API.EF.Models;
namespace Cars.API.EF.Repository
{
    public interface ICarRepository
    {
        Task<bool> AddCar(Car car);
        Task<IEnumerable<Car>> GetCars();
        Task<bool> UpdateCar(Guid id, Car car);
        Task<bool> DeleteCar(Guid id);
    }
}
