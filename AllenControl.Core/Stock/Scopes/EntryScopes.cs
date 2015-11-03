using System;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Enums;
using static DomainNotificationHelper.Validation.AssertionConcern;

namespace AllenControl.Core.Stock.Scopes
{
    public static class EntryScopes
    {
        public static bool CancelEntryScopeIsValid(this Entry entry)
        {
            return IsSatisfiedBy(
                AssertTrue(entry.Status != EntryStatus.Canceled, "Entrada já cancelada.")
                );
        }

        public static bool RegisterScopeIsValid(this Entry entry)
        {
            throw new NotImplementedException();
        }
    }
}