using System;
using AllenControl.Core.Stock.Scopes;

namespace AllenControl.Core.Stock.Entities
{
    public class OrderItem
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public string ProductId { get; private set; }
        public Product Product { get; private set; }

        public bool Register()
        {
            return this.RegisterScopeIsValid(Product);
        }

        public void AddProduct(Product product, int quantity, decimal price)
        {
            if (!this.AddProductScopeIsValid(product, quantity, price))
                return;

            Price = price;
            Quantity = quantity;
            Product = product;
            ProductId = product.Id;

            Product.UpdateQuantityOnHand(Product.QuantityOnHand - quantity);
        }
    }
}