using System;
using AllenControl.Core.Account.Entities;
using AllenControl.Core.Stock.Enums;
using AllenControl.Core.Stock.Scopes;

namespace AllenControl.Core.Stock.Entities
{
    public class StockMovement
    {
        protected StockMovement() { }

        public StockMovement(Product product, int amount, decimal price, string userId, MovementType movementType)
        {
            Id = Guid.NewGuid().ToString();
            Price = price;
            UserId = userId;
            Amount = amount;
            Product = product;
            Date = DateTime.Now;
            Status = MovementStatus.Created;
            TypeOfMovement = movementType;
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

        public MovementType TypeOfMovement { get; private set; }
        public MovementStatus Status { get; private set; }

        public void Register()
        {
            this.RegisterScopeIsValid();
        }

        public void MarkAsAccomplished()
        {
            Accomplished = DateTime.Now;
            Status = MovementStatus.Accomplished;

            switch (TypeOfMovement)
            {
                case MovementType.Entry:
                    Product.UpdateQuantityOnHand(Product.QuantityOnHand + Amount);
                    break;
                default:
                    Product.UpdateQuantityOnHand(Product.QuantityOnHand - Amount);
                    break;
            }

        }

        public void Cancel()
        {
            if (!this.CancelEntryScopeIsValid())
                return;

            Canceled = DateTime.Now;
            Status = MovementStatus.Canceled;
        }
    }
}