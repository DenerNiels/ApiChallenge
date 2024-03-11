using ApiChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiChallenge.Context
{
    public class ApiContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public ApiContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Ibge> Ibges { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = _configuration.GetConnectionString("ConexaoPadrao");
            optionsBuilder.UseSqlServer(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new IbgeConfiguration());

        }
    }
}
