using System.Collections.Generic;
using AllenControl.Core.Stock.Entities;

namespace AllenControl.Core.Stock.Services
{
    public interface ICategoryAppService
    {
        IEnumerable<Category> Get();
        Category Enable(string id);
        Category Disable(string id);
        Category Register(string title);
    }
}