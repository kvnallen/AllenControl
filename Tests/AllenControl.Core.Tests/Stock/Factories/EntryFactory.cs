using System;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Enums;

namespace AllenControl.Core.Tests.Stock.Factories
{
    public static class EntryFactory
    {
        public static StockMovement ValidStockMovement => new StockMovement(
            product: ProductFactory.ValidProduct,
            amount: 100,
            price: 20m,
            userId: Guid.NewGuid().ToString(),
            movementType: MovementType.Entry);

        public static StockMovement ValidStockMovementOfExit => new StockMovement(
           product: ProductFactory.ValidProduct,
           amount: 100,
           price: 20m,
           userId: Guid.NewGuid().ToString(),
           movementType: MovementType.Exit);

        public static StockMovement StockMovementWithNegativeAmount => new StockMovement(
            product: ProductFactory.ValidProduct,
            amount: -100,
            price: 20m,
            userId: Guid.NewGuid().ToString(),
            movementType: MovementType.Entry);

        public static StockMovement StockMovementWithNegativePrice => new StockMovement(
           product: ProductFactory.ValidProduct,
           amount: 100,
           price: -20m,
           userId: Guid.NewGuid().ToString(),
           movementType: MovementType.Entry);

        public static StockMovement StockMovementWithoutProduct => new StockMovement(
           product: null,
           amount: 100,
           price: -20m,
           userId: Guid.NewGuid().ToString(),
           movementType: MovementType.Entry);
    }
}