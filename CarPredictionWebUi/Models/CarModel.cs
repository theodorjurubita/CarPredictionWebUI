using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarPredictionWebUi.Models
{
    public class CarModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int HorsePower { get; set; }

        public string Transmission { get; set; }

        public string Fuel { get; set; }

        public float Mileage { get; set; }

        public float Price { get; set; }
    }
}