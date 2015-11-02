using System;
using System.Collections.Generic;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Scopes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Stock.Scopes
{
    [TestClass]
    public class OrderScopesTests
    {
        private List<OrderItem> _validItens;
        private Order _validOrder;
        private Product _product;

        [TestInitialize]
        public void Init()
        {
            _validItens = new List<OrderItem>();

            var item = new OrderItem();

            _product = new Product(
                description: "Produto Comum",
                price: 13.9m,
                quantityOnHand: 300,
                image: "",
                unitOfMeasurementId: Guid.NewGuid().ToString(),
                categoryId: Guid.NewGuid().ToString());

            item.AddProduct(_product, 20, 30m);

            _validItens.Add(item);

            _validOrder = new Order(
                orderItens: _validItens,
                userId: Guid.NewGuid().ToString(),
                notes: "Nothing...");
        }

        [TestMethod, TestCategory("Order - RegisterScopes")]
        public void ShouldRegisterOrder()
        {
            Assert.AreEqual(true, _validOrder.RegisterScopeIsValid());
        }


        [TestMethod, TestCategory("Order - RegisterScopes")]
        public void ShouldNotRegisterOrderWhenHaveNoItens()
        {
            var order = new Order(
                orderItens: new List<OrderItem>(),
                userId: Guid.NewGuid().ToString(),
                notes: "...");

            Assert.AreEqual(false, order.RegisterScopeIsValid());
        }
    }
}