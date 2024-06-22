using ProjektSzT2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ProjektSzT2
{
    public class ProjectDbContext : DbContext
    {
        private IConfiguration _configuration { get; }
        
        public ProjectDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=project;trusted_connection=true;", x => x.MigrationsHistoryTable("__EFMigrationsHistory", "Project"));
        }

    }
}
