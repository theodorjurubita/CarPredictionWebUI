using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPredictionWebUi.Models;
using CarPredictionWebUi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CarPredictionWebUi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController:ControllerBase
    {
        public IMongoService MongoService;

        public CarsController( IMongoService mongoService)
        {
            MongoService = mongoService;
        }

        //GET: /api/cars
        public IEnumerable<CarModel> GetCars()
        {
            var cars = MongoService.GetCars();
            return cars.Result;
        }
        
        [Route("DataPoints/{carModel}")]
        public IEnumerable<ChartDataPoint> GetDataPoints(string carModel)
        {
            var cars = MongoService.GetCarsByModel(carModel).Result.Select(c=> new ChartDataPoint
            {
                X = c.Year,
                Y = c.Price
            }).OrderBy(c=>c.X);

            return cars;
        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteCar(string id)
        {
            MongoService.DeleteCar(id);
        }
    }
}
