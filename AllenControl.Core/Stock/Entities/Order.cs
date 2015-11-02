using System;
using System.Collections.Generic;
using System.Linq;
using AllenControl.Core.Account.Entities;
using AllenControl.Core.Stock.Enums;
using AllenControl.Core.Stock.Scopes;

namespace AllenControl.Core.Stock.Entities
{
    public class Order
    {
        protected Order() { }

        public Order(List<OrderItem> orderItens, string userId, string notes)
        {
            Id = Guid.NewGuid().ToString();
            UserId = userId;
            Notes = notes;
            OrderItems = new List<OrderItem>();
            orderItens.ForEach(AddItem);
            Status = OrderStatus.Created;
            Date = DateTime.Now;
        }

        public string Id { get; private set; }
        public string Notes { get; private set; }
        public ICollection<OrderItem> OrderItems { get; private set; }
        public string UserId { get; private set; }
        public User User { get; private set; }
        public OrderStatus Status { get; private set; }

        public DateTime PaidDate { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime DeliveredDate { get; private set; }

        public decimal Total => OrderItems.Sum(x => x.Price * x.Quantity);

        public void Register()
        {
            this.RegisterScopeIsValid();
        }

        public void AddItem(OrderItem item)
        {
            if (item.Register())
                OrderItems.Add(item);
        }

        public void MarkAsPaid()
        {
            if (Status == OrderStatus.Canceled)
                return;

            PaidDate = DateTime.Now;
            Status = OrderStatus.Paid;
        }

        public void MarkAsDelivered()
        {
            if (Status == OrderStatus.Canceled)
                return;

            Status = OrderStatus.Delivered;
            DeliveredDate = DateTime.Now;
        }

        public void Cancel()
        {
            Status = OrderStatus.Canceled;
        }
    }
}