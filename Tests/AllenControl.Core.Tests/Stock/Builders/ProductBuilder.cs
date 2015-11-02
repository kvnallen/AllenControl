using System;
using AllenControl.Core.Stock.Entities;

namespace AllenControl.Core.Tests.Stock.Builders
{
    public static class ProductBuilder
    {
        public static Product ValidProduct => new Product(
            description: "Resma A4",
            price: 13.9m,
            quantityOnHand: 200,
            image: "",
            unitOfMeasurementId: Guid.NewGuid().ToString(),
            categoryId: Guid.NewGuid().ToString());
    }
}