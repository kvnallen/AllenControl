using System;

namespace AllenControl.Core.Stock.Entities
{
    public class OrderItem
    {
        protected OrderItem()
        {
        }

        public OrderItem(int quantity, decimal price, Product product)
        {
            Id = Guid.NewGuid().ToString();
            Quantity = quantity;
            ProductId = product.Id;
            Product = product;
            Price = price;
        }

        public string Id { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public string ProductId { get; private set; }
        public Product Product { get; private set; }

        public void WriteOff()
        {
            Product.UpdateQuantityOnHand(Product.QuantityOnHand - Quantity);
        }
    }
}