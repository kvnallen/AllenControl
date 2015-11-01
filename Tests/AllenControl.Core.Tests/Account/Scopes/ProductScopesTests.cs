using System;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Scopes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Account.Scopes
{
    [TestClass]
    public class ProductScopesTests
    {
        [TestCategory("Product - Scopes")]
        public void RegisterScopeIsValid()
        {
            var product = new Product("Resma A4", 20m, 100, "", Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
            Assert.AreEqual(true, product.RegisterScopeIsValid());
        }
    }
}