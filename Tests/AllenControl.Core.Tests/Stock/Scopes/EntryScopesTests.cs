using AllenControl.Core.Stock.Scopes;
using AllenControl.Core.Tests.Stock.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Stock.Scopes
{
    [TestClass]
    public class EntryScopesTests
    {
        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldRegisterEntry()
        {
            Assert.AreEqual(EntryFactory.ValidStockMovement.RegisterScopeIsValid(), true);
        }

        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldNotRegisterEntryWhenAmountIsNegative()
        {
            Assert.IsFalse(EntryFactory.StockMovementWithNegativeAmount.RegisterScopeIsValid());
        }

        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldNotRegisterEntryWhenPriceIsNegative()
        {
            Assert.IsFalse(EntryFactory.StockMovementWithNegativePrice.RegisterScopeIsValid());
        }

        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldNotRegisterEntryWithoutProduct()
        {
            Assert.IsFalse(EntryFactory.StockMovementWithoutProduct.RegisterScopeIsValid());
        }

        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldNotCancelEntryWhenStatusIsCanceled()
        {
            var entry = EntryFactory.ValidStockMovement;
            entry.Cancel();

            Assert.IsFalse(entry.CancelEntryScopeIsValid());
        }
    }
}