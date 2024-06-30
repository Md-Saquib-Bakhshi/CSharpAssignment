using Cars.API.Models;
namespace Cars.API.Repository
{
    public interface ICarRepository
    {
        //Create 
        Task<bool> AddCar(Car car);
        //Read
        Task<IEnumerable<Car>> GetCars();
        //Update
        Task<bool> UpdateCar(Guid id, Car car);
        //Delete
        Task<bool> DeleteCar(Guid id);
    }
}
