using System.Collections.Generic;
using System.Linq;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Repositories;
using AllenControl.Infra.Persistence.DataContexts;

namespace AllenControl.Infra.Repositories
{
    public class UnitOfMeasurementRepository : IUnitOfMeasurementRepository
    {
        private readonly AllenControlDbContext _context;

        public UnitOfMeasurementRepository(AllenControlDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UnitOfMeasurement> Get()
        {
            return _context.UnitOfMeasurements.ToList();
        }

        public void Register(UnitOfMeasurement unitOfMeasurement)
        {
            _context.UnitOfMeasurements.Add(unitOfMeasurement);
        }
    }
}