using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarPredictionWebUi.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CarPredictionWebUi.Services
{
    public class MongoService : IMongoService
    {
        public IMongoCollection<CarModel> CarCollection { get; set; }
        public IMongoCollection<User> UsersCollection { get; set; }

        public MongoService(string databaseUrl, string databaseName, string collectionName)
        {
            var mongoClient = new MongoClient(databaseUrl);
            var mongoDatabase = mongoClient.GetDatabase(databaseName);
            CarCollection = mongoDatabase.GetCollection<CarModel>(collectionName);
            UsersCollection = mongoDatabase.GetCollection<User>("Users");
        }

        public async Task InsertCarInfo(CarModel carModel) => await CarCollection.InsertOneAsync(carModel);

        public async Task<List<CarModel>> GetCars()
        {
            var cars = new List<CarModel>();

            var allDocuments = CarCollection.Find(new BsonDocument());
            await allDocuments.ForEachAsync(doc => cars.Add(doc));

            return cars;
        }

        public async Task<User> GetUser(string userName)
        {
            var users = new List<User>();
            var allUsers = UsersCollection.Find(user => user.Username == userName);
            await allUsers.ForEachAsync(doc => users.Add(doc));
            return users.FirstOrDefault();
        }

        public void DeleteCar(string carId)
        {
            CarCollection.DeleteOne(car => car.Id == carId);
        }
    }
}