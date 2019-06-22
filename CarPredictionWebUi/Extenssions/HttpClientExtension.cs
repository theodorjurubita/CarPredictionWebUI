using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CarPredictionWebUi.Extenssions
{
    public static class HttpClientExtension
    {
        public static void InitializeRegressionService(this HttpClient client)
        {
            client.BaseAddress = new Uri("http://localhost:5000/price");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
