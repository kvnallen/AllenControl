using System;
using System.Collections.Generic;
using System.Linq;
using AllenControl.Core.Stock.Commands;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Repositories;
using AllenControl.Infra.Persistence.DataContexts;

namespace AllenControl.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AllenControlDbContext _context;

        public ProductRepository(AllenControlDbContext context)
        {
            _context = context;
        }

        public string Id { get; set; }

        public IEnumerable<Product> Get()
        {
            return _context.Products.ToList();
        }

        public Product GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Register(Product product)
        {
            _context.Products.Add(product);
        }
    }
}