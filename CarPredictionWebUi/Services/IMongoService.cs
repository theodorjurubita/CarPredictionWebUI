using System.Collections.Generic;
using System.Threading.Tasks;
using CarPredictionWebUi.Models;

namespace CarPredictionWebUi.Services
{
    public interface IMongoService
    {
        Task InsertCarInfo(CarModel carModel);

        Task<List<CarModel>> GetCars();

        Task<User> GetUser(string username);

        void DeleteCar(string carId);

        Task<List<CarModel>> GetCarsByModel(string model);
    }
}