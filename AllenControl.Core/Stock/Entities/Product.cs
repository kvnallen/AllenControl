using System;
using AllenControl.Core.Stock.Scopes;

namespace AllenControl.Core.Stock.Entities
{
    public class Product
    {
        protected Product() { }

        public Product(string description, decimal price, int quantityOnHand, string image, string unitOfMeasurementId, string categoryId)
        {
            Description = description;
            Price = price;
            QuantityOnHand = quantityOnHand;
            Image = image;
            UnitOfMeasurementId = unitOfMeasurementId;
            CategoryId = categoryId;
            Active = true;
            LastModification = DateTime.Now;
        }

        public string Id { get; private set; }
        public int Code { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOnHand { get; private set; }
        public string Image { get; private set; }

        public string UnitOfMeasurementId { get; private set; }
        public UnitOfMeasurement UnitOfMeasurement { get; private set; }

        public string CategoryId { get; private set; }
        public Category Category { get; private set; }

        public bool Active { get; private set; }
        public DateTime LastModification { get; private set; }

        public void Register()
        {
            this.RegisterScopeIsValid();
        }

        public void Activate()
        {
            Active = true;
            LastModification = DateTime.Now;
        }

        public void Deactivate()
        {
            Active = false;
            LastModification = DateTime.Now;
        }

        public void UpdateQuantityOnHand(int quantity)
        {
            QuantityOnHand = quantity;
            LastModification = DateTime.Now;
        }
    }
}
