using Athena.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Athena.Database
{
    public class AthenaContext : DbContext
    {
        public virtual DbSet<ToDo> ToDo { get; set; }
        private readonly IConfiguration configuration;
        public AthenaContext(IConfiguration config)
        {
            configuration = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(configuration.GetConnectionString("DBConnection"));
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        
    }
}
