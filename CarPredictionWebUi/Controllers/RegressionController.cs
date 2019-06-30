using CarPredictionWebUi.Models;
using CarPredictionWebUi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPredictionWebUi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegressionController : ControllerBase
    {
        public IRegressionService RegressionService;
        public IMongoService MongoService;

        public RegressionController(IRegressionService regressionService, IMongoService mongoService)
        {
            RegressionService = regressionService;
            MongoService = mongoService;
        }

        [HttpPost]
        [Route("predict")]
        public PredictionResponse Predict([FromBody] PredictionRequest request)
        {
            var response = RegressionService.Predict(request);
            var result = response.Result;

            var carModel = new CarModel
            {
                Fuel = request.Fuel,
                HorsePower = request.HorsePower,
                Mileage = request.Mileage,
                Model = request.Model,
                Transmission = request.Transmission,
                Year = request.Year,
                Price = result.Price
            };

            //MongoService.InsertCarInfo(carModel);
            return result;
        }
    }
}