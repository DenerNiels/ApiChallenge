using ApiChallenge.Models;

namespace ApiChallenge.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiContext _context;

        public UserRepository(ApiContext context)
        {
            _context = context;
        }

         public async Task<User> CreateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> LoginUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
