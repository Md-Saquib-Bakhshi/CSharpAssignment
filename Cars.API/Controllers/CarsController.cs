using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cars.API.Models;
using Cars.API.Repository;

namespace Cars.API.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarRepository _carRepository;

        public CarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddCar(Car car)
        {
            await _carRepository.AddCar(car);
            return Ok("Car added successfully.");
        }

        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var allCars = await _carRepository.GetCars();
            return Ok(allCars);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCars(Guid id, Car car)
        {
            var isExistedCar = await _carRepository.UpdateCar(id, car);
            if (isExistedCar != null)
            {
                return Ok(isExistedCar);
            }
            return NotFound("\n!!!Car not found!!!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCars(Guid id)
        {
            var isExistedCar = await _carRepository.DeleteCar(id);
            if (isExistedCar != null)
            {
                return Ok("\n!!!Car deleted successfully!!!");
            }
            return NotFound("\n!!!Car not found!!!");
        }
    }
}
