using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Scopes;
using AllenControl.Core.Tests.Stock.Builders;
using AllenControl.Core.Tests.Stock.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Stock.Scopes
{
    [TestClass]
    public class CategoryScopesTests
    {
        [TestMethod, TestCategory("Category - Scopes")]
        public void ShouldRegisterCategory()
        {
            Assert.AreEqual(true, CategoryFactory.ValidCategory.RegisterScopeIsValid());
        }

        [TestMethod, TestCategory("Category - Scopes")]
        public void ShouldNotRegisterCategoryWhenTitleIsNullOrEmpty()
        {
            var category = new Category(null);
            Assert.AreEqual(false, category.RegisterScopeIsValid());
        }
    }
}