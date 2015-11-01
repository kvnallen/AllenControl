using System;
using System.Collections.Generic;
using System.Linq;
using AllenControl.Core.Account.Entities;
using AllenControl.Core.Stock.Enums;

namespace AllenControl.Core.Stock.Entities
{
    public class Order
    {
        protected Order() { }

        public Order(string userId, string notes)
        {
            Notes = notes;
            UserId = userId;
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

        public void MarkAsPaid()
        {
            if (Status == OrderStatus.Canceled)
                return;

            OrderItems.ToList().ForEach(x => x.WriteOff());
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

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
    }
}