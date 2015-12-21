using System.Collections.Generic;
using AllenControl.Core.Stock.Entities;

namespace AllenControl.Core.Stock.Services
{
    public interface IProductAppService
    {
        IEnumerable<Product> Get();
    }
}