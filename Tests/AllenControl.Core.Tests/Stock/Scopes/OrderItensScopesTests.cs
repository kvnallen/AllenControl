using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Scopes;
using AllenControl.Core.Tests.Stock.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Stock.Scopes
{
    [TestClass]
    public class OrderItensScopesTests
    {
        [TestMethod, TestCategory("OrderItens - RegisterScopes")]
        public void ShouldNotAddProductWhenQuantityIsOutOfStock()
        {
            var orderItem = new OrderItem();
            Assert.AreEqual(false, orderItem.AddProductScopeIsValid(ProductFactory.ValidProduct, 320, 30));
        }
    }
}