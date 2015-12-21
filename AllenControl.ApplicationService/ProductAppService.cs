using System.Collections.Generic;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Repositories;
using AllenControl.Core.Stock.Services;

namespace AllenControl.ApplicationService
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductRepository _productRepository;

        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}