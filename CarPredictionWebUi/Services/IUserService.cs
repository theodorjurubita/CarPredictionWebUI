using System.Threading.Tasks;
using CarPredictionWebUi.Models;

namespace CarPredictionWebUi.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }
}