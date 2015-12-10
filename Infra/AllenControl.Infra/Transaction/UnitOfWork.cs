using AllenControl.Infra.Persistence.DataContexts;

namespace AllenControl.Infra.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AllenControlDbContext _context;

        public UnitOfWork(AllenControlDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            throw new System.NotImplementedException();
        }
    }
}