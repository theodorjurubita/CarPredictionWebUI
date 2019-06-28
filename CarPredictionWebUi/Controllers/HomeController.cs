using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarPredictionWebUi.Models;
using CarPredictionWebUi.Services;

namespace CarPredictionWebUi.Controllers
{
    public class HomeController : Controller
    {
        //Todo: apiul de login cu parola hashuita ->Done
        //Todo: apiul de mongo -> Done
        //Todo: delete car si tabel cu boostrap pt paginare ->Done
        public IMongoService MongoService;

        public IRegressionService RegressionService;

        public HomeController(IRegressionService regressionService, IMongoService mongoService)
        {
            RegressionService = regressionService;
            MongoService = mongoService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarForm()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        [Route("cars")]
        public IActionResult CarsManagement()
        {
            var cars = MongoService.GetCars().Result;

            return View("CarsManagement",cars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}