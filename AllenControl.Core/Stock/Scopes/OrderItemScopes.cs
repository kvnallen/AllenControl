using AllenControl.Core.Stock.Entities;
using static DomainNotificationHelper.Validation.AssertionConcern;

namespace AllenControl.Core.Stock.Scopes
{
    public static class OrderItemScopes
    {
        public static bool RegisterScopeIsValid(this OrderItem item, Product product)
        {
            return IsSatisfiedBy
            (
                AssertIsGreaterThan(item.Price, 0, "Preço inválido"),
                AssertNotNull(item.ProductId, "Produto inválido"),
                AssertIsGreaterThan(item.Quantity, 0, "Quantidade inválida")
            );
        }

        public static bool AddProductScopeIsValid(this OrderItem item, Product product, int quantity, decimal price)
        {
            return
                IsSatisfiedBy(
                    AssertNotNull(product, "O produto é obrigatório")
                ) && IsSatisfiedBy(
                AssertIsGreaterThan(quantity, 0, $"A quantidade do produto {product.Description} deve ser maior que zero."),
                AssertIsGreaterThan(price, 0, $"O preço do produto {product.Description} deve ser maior que zero."),
                AssertIsGreaterOrEqualThan((product.QuantityOnHand - quantity), 0, "Produto fora de estoque: " + product.Description)
                );
        }
    }
}