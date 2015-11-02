using AllenControl.Core.Stock.Entities;
using static DomainNotificationHelper.Validation.AssertionConcern;

namespace AllenControl.Core.Stock.Scopes
{
    public static class ProductScopes
    {
        public static bool RegisterScopeIsValid(this Product product)
        {
            return IsSatisfiedBy(
                    AssertLength(product.Description, 4, 100, "O produto deve ter entre 4 e 100 caracteres."),
                    AssertIsGreaterThan(product.Price, 0, "O valor unitário deve ser maior que zero."),
                    AssertNotEmpty(product.CategoryId, "A categoria do produto é obrigatória."),
                    AssertNotEmpty(product.UnitOfMeasurementId, "A unidade de medida é obrigatória.")
                );
        }
    }
}