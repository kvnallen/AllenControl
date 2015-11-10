using AllenControl.Core.Stock.Scopes;
using AllenControl.Core.Tests.Stock.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Stock.Scopes
{
    [TestClass]
    public class EntryScopesTests
    {
        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldRegisterEntry()
        {
            Assert.AreEqual(EntryFactory.ValidEntry.RegisterScopeIsValid(), true);
        }

        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldNotRegisterEntryWhenAmountIsNegative()
        {
            Assert.IsFalse(EntryFactory.EntryWithNegativeAmount.RegisterScopeIsValid());
        }

        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldNotRegisterEntryWhenPriceIsNegative()
        {
            Assert.IsFalse(EntryFactory.EntryWithNegativePrice.RegisterScopeIsValid());
        }

        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldNotRegisterEntryWithoutProduct()
        {
            Assert.IsFalse(EntryFactory.EntryWithoutProduct.RegisterScopeIsValid());
        }

        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldNotCancelEntryWhenStatusIsCanceled()
        {
            var entry = EntryFactory.ValidEntry;
            entry.Cancel();

            Assert.IsFalse(entry.CancelEntryScopeIsValid());
        }
    }
}