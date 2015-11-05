using System;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Enums;
using DomainNotificationHelper.Validation;
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
            return IsSatisfiedBy(
                AssertNotEmpty(entry.ProductId, "O produto é obrigatório"),
                AssertIsGreaterThan(entry.Amount, 0, "A quantidade deve ser maior que zero."),
                AssertIsGreaterThan(entry.Price, 0, "O preço deve ser maior que zero.")

                );
        }
    }
}