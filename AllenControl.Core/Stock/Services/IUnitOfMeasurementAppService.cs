using System.Collections.Generic;
using AllenControl.Core.Stock.Entities;

namespace AllenControl.Core.Stock.Services
{
    public interface IUnitOfMeasurementAppService
    {
        IEnumerable<UnitOfMeasurement> Get();
        UnitOfMeasurement Register(string name);
    }
}