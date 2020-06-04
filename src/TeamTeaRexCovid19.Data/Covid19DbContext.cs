using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TeamTeaRexCovid19.Data.Schema;

namespace TeamTeaRexCovid19.Data
{
    public class Covid19DbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public Covid19DbContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration;
        }

        public virtual DbSet<InitialQuestionsTable> InitialQuestions { get; set; }
        public virtual DbSet<DailyQuestionsTable> DailyQuestions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            }
        }
    }
}