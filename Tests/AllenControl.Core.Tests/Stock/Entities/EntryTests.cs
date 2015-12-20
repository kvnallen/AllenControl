using AllenControl.Core.Stock.Enums;
using AllenControl.Core.Tests.Stock.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Stock.Entities
{
    [TestClass]
    public class GivenNewEntry
    {
        [TestMethod, TestCategory("Entry - Given a new Entry")]
        public void StatusShouldBeCreated()
        {
            Assert.IsTrue(EntryFactory.ValidStockMovement.Status == MovementStatus.Created);
        }
    }


    [TestClass]
    public class EntryTests
    {
        [TestMethod, TestCategory("Entry - Method Tests")]
        public void QuantityOfProductShouldBeIncrementedWhenIsMarkedAsAccomplishedAndTypeIsEntry()
        {
            var entry = EntryFactory.ValidStockMovement;
            entry.MarkAsAccomplished();

            Assert.AreEqual(300, entry.Product.QuantityOnHand);
        }

        [TestMethod, TestCategory("Entry - Method Tests")]
        public void ShouldCancelEntry()
        {
            var validEntry = EntryFactory.ValidStockMovement;
            validEntry.Cancel();

            Assert.IsTrue(validEntry.Status == MovementStatus.Canceled);
        }
    }
}