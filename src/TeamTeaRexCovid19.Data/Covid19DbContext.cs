using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TeamTeaRexCovid19.Data
{
    public class Covid19DbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public Covid19DbContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            }
        }
    }
}