using System;
using AllenControl.Core.Stock.Enums;
using AllenControl.Core.Tests.Stock.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Stock.Entities
{
    [TestClass]
    public class GivenNewMovement
    {
        [TestMethod, TestCategory("Movement - Given a new Movement")]
        public void StatusShouldBeCreated()
        {
            Assert.IsTrue(EntryFactory.ValidStockMovement.Status == MovementStatus.Created);
        }

        [TestMethod, TestCategory("Movement - Given a new Movement")]
        public void DateMustBeToday()
        {
            Assert.IsTrue(EntryFactory.ValidStockMovement.Date == DateTime.Now);
        }
    }


    [TestClass]
    public class MovementTests
    {
        [TestMethod, TestCategory("Stock Movement - Method Tests")]
        public void QuantityOfProductShouldBeIncrementedWhenIsMarkedAsAccomplishedAndTypeIsEntry()
        {
            var entry = EntryFactory.ValidStockMovement;
            entry.MarkAsAccomplished();

            Assert.AreEqual(300, entry.Product.QuantityOnHand);
        }

        [TestMethod, TestCategory("Stock Movement - Method Tests")]
        public void QuantityOfProductShouldBeDecrementedWhenIsMarkedAsAccomplishedAndTypeIsExit()
        {
            var entry = EntryFactory.ValidStockMovementOfExit;
            entry.MarkAsAccomplished();

            Assert.AreEqual(100, entry.Product.QuantityOnHand);
        }

        [TestMethod, TestCategory("Stock Movement - Method Tests")]
        public void ShouldCancelEntry()
        {
            var validEntry = EntryFactory.ValidStockMovement;
            validEntry.Cancel();

            Assert.IsTrue(validEntry.Status == MovementStatus.Canceled);
        }
    }
}