using System;
using System.Collections.Generic;
using AllenControl.Core.Stock.Commands;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Repositories;

namespace AllenControl.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public IEnumerable<Product> Get()
        {
            throw new System.NotImplementedException();
        }

        public Product GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public Product Register(NewProductCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}