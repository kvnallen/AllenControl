using System;
using AllenControl.Core.Stock.Entities;

namespace AllenControl.Core.Tests.Stock.Factories
{
    public static class ProductFactory
    {
        public static Product ValidProduct => new Product(
            description: "Resma A4",
            price: 13.9m,
            quantityOnHand: 200,
            image: "",
            unitOfMeasurementId: Guid.NewGuid().ToString(),
            categoryId: Guid.NewGuid().ToString());

        public static Product ProductWithNegativePrice => new Product(
            description: "Resma A4",
            price: -13.9m,
            quantityOnHand: 200,
            image: "",
            unitOfMeasurementId: Guid.NewGuid().ToString(),
            categoryId: Guid.NewGuid().ToString());

        public static Product ProductWithNegativeQuantityOnHand => new Product(
            description: "Resma A4",
            price: 13.9m,
            quantityOnHand: -200,
            image: "",
            unitOfMeasurementId: Guid.NewGuid().ToString(),
            categoryId: Guid.NewGuid().ToString());

        public static Product ProductWithoutCategory => new Product(
           description: "Resma A4",
           price: 13.9m,
           quantityOnHand: 200,
           image: "",
           unitOfMeasurementId: Guid.NewGuid().ToString(),
           categoryId: null);

        public static Product ProductWithoutUnitOfMeasurement => new Product(
           description: "Resma A4",
           price: 13.9m,
           quantityOnHand: 200,
           image: "",
           unitOfMeasurementId: null,
           categoryId: Guid.NewGuid().ToString());
    }
}