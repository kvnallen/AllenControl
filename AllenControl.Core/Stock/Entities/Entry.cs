using System;
using AllenControl.Core.Account.Entities;
using AllenControl.Core.Stock.Enums;

namespace AllenControl.Core.Stock.Entities
{
    public class Entry
    {
        protected Entry() { }

        public Entry(string productId, int quantity, decimal price, string userId)
        {
            Id = Guid.NewGuid().ToString();
            Price = price;
            UserId = userId;
            Quantity = quantity;
            ProductId = productId;
            Date = DateTime.Now;
            Status = EntryStatus.Created;
        }

        public string Id { get; private set; }

        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public string ProductId { get; private set; }
        public Product Product { get; private set; }

        public DateTime Date { get; private set; }
        public DateTime? Canceled { get; private set; }
        public DateTime? Accomplished { get; private set; }

        public User User { get; private set; }
        public string UserId { get; private set; }

        public EntryStatus Status { get; private set; }

        public void WriteOff()
        {
            Accomplished = DateTime.Now;
            Status = EntryStatus.Accomplished;
            Product.UpdateQuantityOnHand(Product.QuantityOnHand + Quantity);
        }

        public void Cancel()
        {
            Canceled = DateTime.Now;
            Status = EntryStatus.Canceled;
        }
    }
}