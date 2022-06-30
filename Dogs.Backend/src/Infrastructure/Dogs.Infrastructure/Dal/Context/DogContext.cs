using Dogs.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dogs.Infrastructure.Dal.Context
{
    public class DogContext : DbContext
    {
        public DogContext(DbContextOptions<DogContext> options) : base(options)
        {

        }
        public DbSet<Dog> Dogs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
