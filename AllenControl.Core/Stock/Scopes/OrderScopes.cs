using AllenControl.Core.Stock.Entities;
using static DomainNotificationHelper.Validation.AssertionConcern;

namespace AllenControl.Core.Stock.Scopes
{
    public static class OrderScopes
    {
        public static bool RegisterScopeIsValid(this Order order)
        {
            return IsSatisfiedBy(AssertIsGreaterThan(order.OrderItems.Count, 0, "O pedido deve ter no mínimo 1 item."));
        }
    }
}