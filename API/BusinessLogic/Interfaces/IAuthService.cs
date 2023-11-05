using DataAccess.Models;

namespace BusinessLogic.Interfaces
{
    public interface IAuthService
    {
        public Task<User> Register(User newUser);
        public Task<User> Login(string email, string password);
    }
}
