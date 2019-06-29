namespace CarPredictionWebUi.Models
{
    public class PredictionRequest
    {
        public string Model { get; set; }

        public int Year { get; set; }

        public int HorsePower { get; set; }

        public string Fuel { get; set; }

        public string Transmission { get; set; }
        
        public int Mileage { get; set; }
    }
}