using AllenControl.Core.Stock.Entities;
using DomainNotificationHelper.Validation;

namespace AllenControl.Core.Stock.Scopes
{
    public static class ProductScopes
    {
        public static bool RegisterScopeIsValid(this Product product)
        {
            return AssertionConcern.IsSatisfiedBy(
                    AssertionConcern.AssertLength(product.Description, 4, 100, "O produto deve ter entre 4 e 100 caracteres."),
                    AssertionConcern.AssertIsGreaterThan(product.Price, 0, "O valor unitário deve ser maior que zero."),
                    AssertionConcern.AssertNotEmpty(product.CategoryId, "A categoria do produto é obrigatória."),
                    AssertionConcern.AssertNotEmpty(product.UnitOfMeasurementId, "A unidade de medida é obrigatória.")
                );
        }
    }
}