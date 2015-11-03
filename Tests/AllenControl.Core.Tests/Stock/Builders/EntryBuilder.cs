using System;
using AllenControl.Core.Stock.Entities;

namespace AllenControl.Core.Tests.Stock.Builders
{
    public static class EntryBuilder
    {
        public static Entry ValidEntry => new Entry(
            productId: Guid.NewGuid().ToString(),
            amount: 100,
            price: 20m,
            userId: Guid.NewGuid().ToString());

        public static Entry EntryWithNegativeAmount => new Entry(
            productId: Guid.NewGuid().ToString(),
            amount: -100,
            price: 20m,
            userId: Guid.NewGuid().ToString());

        public static Entry EntryWithNegativePrice => new Entry(
           productId: Guid.NewGuid().ToString(),
           amount: 100,
           price: -20m,
           userId: Guid.NewGuid().ToString());

        public static Entry EntryWithoutProduct => new Entry(
           productId: null,
           amount: 100,
           price: -20m,
           userId: Guid.NewGuid().ToString());
    }
}