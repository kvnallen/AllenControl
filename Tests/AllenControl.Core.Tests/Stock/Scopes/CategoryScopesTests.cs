using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Scopes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Stock.Scopes
{
    [TestClass]
    public class CategoryScopesTests
    {
        [TestMethod, TestCategory("Category - Scopes")]
        public void ShouldRegisterCategory()
        {
            var category = new Category("Categoria Básica");
            Assert.AreEqual(true, category.RegisterScopeIsValid());
        }

        [TestMethod, TestCategory("Category - Scopes")]
        public void ShouldNotRegisterCategoryWhenTitleIsNullOrEmpty()
        {
            var category = new Category(null);
            Assert.AreEqual(false, category.RegisterScopeIsValid());
        }
    }
}