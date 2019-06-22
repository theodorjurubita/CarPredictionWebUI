using CarPredictionWebUi.Models;
using CarPredictionWebUi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarPredictionWebUi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegressionController : ControllerBase
    {
        public IRegressionService RegressionService;

        public RegressionController(IRegressionService regressionService)
        {
            RegressionService = regressionService;
        }

        [HttpPost]
        [Route("predict")]
        public PredictionResponse Predict([FromBody] PredictionRequest request)
        {
            var response = RegressionService.Predict(request);
            return response.Result;
        }
    }
}