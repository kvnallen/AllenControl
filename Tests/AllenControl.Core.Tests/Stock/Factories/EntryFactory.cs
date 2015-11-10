using System;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Tests.Stock.Factories;

namespace AllenControl.Core.Tests.Stock.Builders
{
    public static class EntryFactory
    {
        public static Entry ValidEntry => new Entry(
            product: ProductFactory.ValidProduct,
            amount: 100,
            price: 20m,
            userId: Guid.NewGuid().ToString());

        public static Entry EntryWithNegativeAmount => new Entry(
            product: ProductFactory.ValidProduct,
            amount: -100,
            price: 20m,
            userId: Guid.NewGuid().ToString());

        public static Entry EntryWithNegativePrice => new Entry(
           product: ProductFactory.ValidProduct,
           amount: 100,
           price: -20m,
           userId: Guid.NewGuid().ToString());

        public static Entry EntryWithoutProduct => new Entry(
           product: null,
           amount: 100,
           price: -20m,
           userId: Guid.NewGuid().ToString());
    }
}