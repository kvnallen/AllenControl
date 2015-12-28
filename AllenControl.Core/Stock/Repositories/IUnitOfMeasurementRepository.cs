using System.Collections.Generic;
using AllenControl.Core.Stock.Entities;

namespace AllenControl.Core.Stock.Repositories
{
    public interface IUnitOfMeasurementRepository
    {
        IEnumerable<UnitOfMeasurement> Get();
        void Register(UnitOfMeasurement unitOfMeasurement);
    }
}