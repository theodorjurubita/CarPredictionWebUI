using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarPredictionWebUi.Models;
using CarPredictionWebUi.Services;

namespace CarPredictionWebUi.Controllers
{
    public class HomeController : Controller
    {
        //Todo: apiul de login cu parola hashuita
        //Todo: apiul de mongo -> Done
        //Todo: delete car si tabel cu boostrap pt paginare

        public IRegressionService RegressionService;

        public HomeController(IRegressionService regressionService)
        {
            RegressionService = regressionService;
        }
            

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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

        public IActionResult CarsManagement()
        {
            IEnumerable<PredictionRequest> cars = new List<PredictionRequest>
            {
                new PredictionRequest
                {
                    Fuel = "Motorina",
                    HorsePower = 12,
                    Mileage = 12357,
                    Transmission = "Automata",
                    Year = 2016,
                    Model = "Seria 3"
                }
            };
            return View(cars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
