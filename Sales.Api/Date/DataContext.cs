using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Sales.Shared.Ettities;
using System.Security.Cryptography.X509Certificates;

namespace Sales.Api.Date
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
             
        }
        // mapiar las clases
        public DbSet<Country> Countries { get; set; }
        // evitar que se repita los nombres. se hace con override onmodelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
        }

    }
}
