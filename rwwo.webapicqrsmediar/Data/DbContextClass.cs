using Microsoft.EntityFrameworkCore;
using rwwo.webapicqrsmediar.Models;

namespace rwwo.webapicqrsmediar.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<StudentDetails> students { get; set; }
    }
}
