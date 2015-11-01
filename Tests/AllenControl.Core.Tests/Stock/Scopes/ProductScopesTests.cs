using System;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Scopes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Stock.Scopes
{
    [TestClass]
    public class ProductScopesTests
    {
        private readonly Product _validProduct = new Product(
            description: "Resma A4",
            price: 20m, 
            quantityOnHand: 100, 
            image: "",
            unitOfMeasurementId: Guid.NewGuid().ToString(),
            categoryId: Guid.NewGuid().ToString());

        [TestMethod]
        [TestCategory("Product - RegisterScopes")]
        public void ShouldRegisterProduct()
        {
            Assert.AreEqual(true, _validProduct.RegisterScopeIsValid());
        }

        [TestMethod]
        [TestCategory("Product - RegisterScopes")]
        public void ShouldNotRegisterProductWhenDescriptionIsNull()
        {
            var product = new Product("", 20m, 100, "", Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
            Assert.AreEqual(false, product.RegisterScopeIsValid());
        }

        [TestMethod]
        [TestCategory("Product - RegisterScopes")]
        public void ShouldNotRegisterProductWhenPriceIsLowerOrEqualThanZero()
        {
            var product = new Product("", -3m, 100, "", Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
            var product2 = new Product("", 0m, 100, "", Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
            Assert.AreEqual(false, product.RegisterScopeIsValid());
            Assert.AreEqual(false, product2.RegisterScopeIsValid());
        }

        [TestMethod]
        [TestCategory("Product - RegisterScopes")]
        public void ShouldNotRegisterProductWhenCategoryIdIsNull()
        {
            var product = new Product(
                description: "",
                price: 20m,
                quantityOnHand: 100,
                image: "",
                unitOfMeasurementId: Guid.NewGuid().ToString(),
                categoryId: "");

            Assert.AreEqual(false, product.RegisterScopeIsValid());
        }


        [TestMethod]
        [TestCategory("Product - RegisterScopes")]
        public void ShouldNotRegisterProductWhenUnitOfMeasurementsNull()
        {
            var product = new Product(
                description: "",
                price: 20m,
                quantityOnHand: 100,
                image: "",
                unitOfMeasurementId: "",
                categoryId: Guid.NewGuid().ToString());

            Assert.AreEqual(false, product.RegisterScopeIsValid());
        }
    }
}