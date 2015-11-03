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
            Assert.AreEqual(EntryBuilder.ValidEntry.RegisterScopeIsValid(), true);
        }

        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldNotRegisterEntryWhenAmountIsNegative()
        {
            Assert.IsFalse(EntryBuilder.EntryWithNegativeAmount.RegisterScopeIsValid());
        }

        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldNotRegisterEntryWhenPriceIsNegative()
        {
            Assert.IsFalse(EntryBuilder.EntryWithNegativePrice.RegisterScopeIsValid());
        }

        [TestMethod, TestCategory("Entry - Scope - Register")]
        public void ShouldNotRegisterEntryWithoutProduct()
        {
            Assert.IsFalse(EntryBuilder.EntryWithoutProduct.RegisterScopeIsValid());
        }
    }
}