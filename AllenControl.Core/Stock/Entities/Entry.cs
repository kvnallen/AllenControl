using System;
using AllenControl.Core.Account.Entities;
using AllenControl.Core.Stock.Enums;
using AllenControl.Core.Stock.Scopes;

namespace AllenControl.Core.Stock.Entities
{
    public class Entry
    {
        protected Entry() { }

        public Entry(Product product, int amount, decimal price, string userId)
        {
            Id = Guid.NewGuid().ToString();
            Price = price;
            UserId = userId;
            Amount = amount;
            Product = product;
            Date = DateTime.Now;
            Status = EntryStatus.Created;
        }

        public string Id { get; private set; }

        public decimal Price { get; private set; }
        public int Amount { get; private set; }

        public string ProductId { get; private set; }
        public Product Product { get; private set; }

        public DateTime Date { get; private set; }
        public DateTime? Canceled { get; private set; }
        public DateTime? Accomplished { get; private set; }

        public User User { get; private set; }
        public string UserId { get; private set; }

        public EntryStatus Status { get; private set; }

        public void Register()
        {
            this.RegisterScopeIsValid();
        }

        public void MarkAsAccomplished()
        {
            Accomplished = DateTime.Now;
            Status = EntryStatus.Accomplished;
            Product.UpdateQuantityOnHand(Product.QuantityOnHand + Amount);
        }

        public void Cancel()
        {
            if (!this.CancelEntryScopeIsValid())
                return;

            Canceled = DateTime.Now;
            Status = EntryStatus.Canceled;
        }
    }
}