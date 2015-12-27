using System.Data.Entity;
using AllenControl.Core.Stock.Entities;

namespace AllenControl.Infra.Persistence.DataContexts
{
    public class AllenControlDbContext : DbContext
    {
        public AllenControlDbContext():base("allen-connection")
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
    }
}