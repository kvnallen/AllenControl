using AllenControl.Core.Stock.Entities;
using DomainNotificationHelper.Validation;

namespace AllenControl.Core.Stock.Scopes
{
    public static class UnitOfMeasurementScopes
    {
        public static bool RegisterScopeIsValid(this UnitOfMeasurement unitOfMeasurement)
        {
            return AssertionConcern.IsSatisfiedBy(

                    AssertionConcern.AssertNotEmpty(unitOfMeasurement.Name, "O nome da unidade de medida é obrigatório.")

                );
        }
    }
}