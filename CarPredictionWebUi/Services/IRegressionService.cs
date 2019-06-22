using CarPredictionWebUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPredictionWebUi.Services
{
    public interface IRegressionService
    {
        Task<PredictionResponse> Predict(PredictionRequest request);
    }
}
