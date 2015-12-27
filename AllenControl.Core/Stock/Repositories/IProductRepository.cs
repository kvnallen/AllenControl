using System.Collections.Generic;
using AllenControl.Core.Stock.Commands;
using AllenControl.Core.Stock.Entities;

namespace AllenControl.Core.Stock.Repositories
{
    public interface IProductRepository
    {
        string Id { get; set; }
        IEnumerable<Product> Get();

        Product GetById(string id);

        void Register(Product product);
    }
}