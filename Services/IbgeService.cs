
using ApiChallenge.Models;

namespace ApiChallenge.Services
{
    public class IbgeService : IIbgeRepository
    {
        public Task<Ibge> CreateIbgeAsync(Ibge ibge)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ibge>> GetStateIbge(string state, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Ibge> UpdateIbge(int id, Ibge ibge)
        {
            throw new NotImplementedException();
        }
    }
}
