using AllenControl.Core.Account.Entities;
using AllenControl.Core.Account.Scopes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllenControl.Core.Tests.Account.Scopes
{
    [TestClass]
    public class UserScopesTests
    {
        private readonly User _validUser = new User("Kevin Allen", "kevinallen@outlook.com", "123456");

        [TestMethod, TestCategory("User - Scopes")]
        public void RegisterScopeIsValid()
        {
            var user = new User("Kevin Allen", "kevinallen@outlook.com", "123456");
            Assert.AreEqual(true, user.RegisterScopeIsValid("123456"));
        }

        [TestMethod, TestCategory("User - Scopes")]
        public void ShouldNotRegisterUserWhenEmailIsNull()
        {
            var user = new User("Kevin", "", "123456");
            Assert.AreEqual(false, user.RegisterScopeIsValid("123456"));
        }

        [TestMethod, TestCategory("User - Scopes")]
        public void RegisterScopeIsInvalidWhenNameIsNull()
        {
            var user = new User("", "kevinallen@outlook.com", "123456");
            Assert.AreEqual(false, user.RegisterScopeIsValid("123456"));
        }

        [TestMethod, TestCategory("User - Scopes")]
        public void RegisterScopeIsInvalidWhenConfirmPasswordNotMatch()
        {
            Assert.AreEqual(false, _validUser.RegisterScopeIsValid("1234567"));
        }
    }
}