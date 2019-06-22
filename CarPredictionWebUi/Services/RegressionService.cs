using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CarPredictionWebUi.Models;
using Newtonsoft.Json;

namespace CarPredictionWebUi.Services
{
    public class RegressionService : IRegressionService
    {
        public HttpClient HttpClient { get; set; }

        public RegressionService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<PredictionResponse> Predict(PredictionRequest request)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, HttpClient.BaseAddress);
            var payload = JsonConvert.SerializeObject(request);
            requestMessage.Content = new StringContent(payload, Encoding.UTF8, "application/json");
            var response = HttpClient.SendAsync(requestMessage).Result;

            var stream = await response.Content.ReadAsStreamAsync();

            return Deserialize(stream);
        }

        private PredictionResponse Deserialize(Stream stream)
        {
            using (var streamReader = new StreamReader(stream))
            {
                using (var jsonTextReader = new JsonTextReader(streamReader))
                {
                    var jsonSerializer = new JsonSerializer();
                    return jsonSerializer.Deserialize<PredictionResponse>(jsonTextReader);
                }
            }
        }
    }
}