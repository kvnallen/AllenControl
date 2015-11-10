using AllenControl.Core.Stock.Enums;
using AllenControl.Core.Tests.Stock.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Stock.Entities
{
    [TestClass]
    public class GivenNewEntry
    {
        [TestMethod, TestCategory("Entry - Given a new Entry")]
        public void StatusShouldBeCreated()
        {
            Assert.IsTrue(EntryFactory.ValidEntry.Status == EntryStatus.Created);
        }
    }


    [TestClass]
    public class EntryTests
    {
        [TestMethod, TestCategory("Entry - Method Tests")]
        public void QuantityOfProductShouldBeIncrementedWhenIsMarkedAsAccomplished()
        {
            var entry = EntryFactory.ValidEntry;
            entry.MarkAsAccomplished();

            Assert.AreEqual(300, entry.Product.QuantityOnHand);
        }

        [TestMethod, TestCategory("Entry - Method Tests")]
        public void ShouldCancelEntry()
        {
            var validEntry = EntryFactory.ValidEntry;
            validEntry.Cancel();

            Assert.IsTrue(validEntry.Status == EntryStatus.Canceled);
        }
    }
}