using System.Data.Entity;

namespace AllenControl.Infra.Persistence.DataContexts
{
    public class AllenControlDbContext : DbContext
    {
        public AllenControlDbContext():base("allen-connection")
        {
            
        }
    }
}