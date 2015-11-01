using AllenControl.Core.Account.Entities;
using static DomainNotificationHelper.Validation.AssertionConcern;

namespace AllenControl.Core.Account.Scopes
{
    public static class UserScopes
    {
        public static bool RegisterScopeIsValid(this User user, string confirmPassword)
        {
            return IsSatisfiedBy(
                AssertMatches(pattern: @"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$", stringValue: user.Email, message: "E-mail inválido"),
                AssertLength(user.Password, 6, 20, "A senha deve conter entre 6 e 20 caracteres"),
                AssertLength(user.Name, 6, 80, "O nome deve conter entre 6 e 80 caracteres"),
                AssertAreEquals(user.Password, confirmPassword, "A senha e a confirmação de senha não conferem.")
                );
        }
    }
}