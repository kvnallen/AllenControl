using AllenControl.Core.Stock.Entities;
using static DomainNotificationHelper.Validation.AssertionConcern;

namespace AllenControl.Core.Stock.Scopes
{
    public static class CategoryScopes
    {
        public static bool RegisterScopeIsValid(this Category category)
        {
            return IsSatisfiedBy(
                AssertNotEmpty(category.Title, "O Título é obrigatório.")
            );
        }
    }
}