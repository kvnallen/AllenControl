using System.Collections.Generic;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Repositories;
using AllenControl.Core.Stock.Services;
using AllenControl.Infra.Transaction;

namespace AllenControl.ApplicationService
{
    public class UnitOfMeasurementAppService : ServiceBase, IUnitOfMeasurementAppService
    {
        private readonly IUnitOfMeasurementRepository _repository;

        public UnitOfMeasurementAppService(IUnitOfMeasurementRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = repository;
        }

        public IEnumerable<UnitOfMeasurement> Get()
        {
            return _repository.Get();
        }

        public UnitOfMeasurement Register(string name)
        {
            var unitOfMeasurement = new UnitOfMeasurement(name);
            unitOfMeasurement.Register();
            
            _repository.Register(unitOfMeasurement);

            Commit();

            return unitOfMeasurement;
        }
    }
}