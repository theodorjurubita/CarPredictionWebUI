using System.Threading.Tasks;
using CarPredictionWebUi.Extenssions;
using CarPredictionWebUi.Models;

namespace CarPredictionWebUi.Services
{
    public class UserService : IUserService
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        public IMongoService MongoService;

        public UserService(IMongoService mongoService)
        {
            MongoService = mongoService;
        }

        public async Task<User> Authenticate(string username, string password)
        {
            var dbUser = MongoService.GetUser(username).Result;
            var authenticate = await Task.Run(() => dbUser.Password.Decrypt() == password);

            // return null if user not found
            if (!authenticate)
                return null;

            // authentication successful so return user details without password
            dbUser.Password = null;
            return dbUser;
        }
    }
}
