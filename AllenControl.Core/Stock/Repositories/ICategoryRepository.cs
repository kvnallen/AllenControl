using System.Collections.Generic;
using AllenControl.Core.Stock.Entities;

namespace AllenControl.Core.Stock.Repositories
{
    public interface ICategoryRepository
    {
        void Register(Category category);
        IEnumerable<Category> Get();
    }
}