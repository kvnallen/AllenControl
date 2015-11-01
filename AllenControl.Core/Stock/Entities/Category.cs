using System;
using AllenControl.Core.Stock.Scopes;

namespace AllenControl.Core.Stock.Entities
{
    public class Category
    {
        public Category(string title)
        {
            Id = Guid.NewGuid().ToString();
            Title = title;
        }

        public string Id { get; private set; }
        public string Title { get; private set; }

        public void Register()
        {
            this.RegisterScopeIsValid();
        }
    }
}