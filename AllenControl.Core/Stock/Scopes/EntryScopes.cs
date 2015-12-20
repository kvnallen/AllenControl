using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Enums;
using static DomainNotificationHelper.Validation.AssertionConcern;

namespace AllenControl.Core.Stock.Scopes
{
    public static class EntryScopes
    {
        public static bool RegisterScopeIsValid(this StockMovement stockMovement)
        {
            return IsSatisfiedBy(
                AssertNotNull(stockMovement.Product, "O produto é obrigatório"),
                AssertIsGreaterThan(stockMovement.Amount, 0, "A quantidade deve ser maior que zero."),
                AssertIsGreaterThan(stockMovement.Price, 0, "O preço deve ser maior que zero.")
                );
        }

        public static bool CancelEntryScopeIsValid(this StockMovement stockMovement)
        {
            return IsSatisfiedBy(
                AssertTrue(stockMovement.Status != MovementStatus.Canceled, "Entrada já cancelada.")
                );
        }
    }
}