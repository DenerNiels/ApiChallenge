using ApiChallenge.Models;

namespace ApiChallenge.Repositories
{
    public interface IUserRepository
    {
        Task<User> CreateAsync(User user);
        Task<User> LoginUserAsync(User user);
        Task<List<User>> GetAllAsync();
    }
}
