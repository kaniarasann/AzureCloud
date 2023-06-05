using Microsoft.EntityFrameworkCore;
using AzureSQL.Model;
namespace AzureSQL.Data
{
    public class AzureDBContext : DbContext
    {
        
        public AzureDBContext(DbContextOptions<AzureDBContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons{ get; private set; }
    }
}