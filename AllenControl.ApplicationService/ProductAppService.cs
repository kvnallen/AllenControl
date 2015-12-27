using System.Collections.Generic;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Repositories;
using AllenControl.Core.Stock.Services;
using AllenControl.Infra.Transaction;

namespace AllenControl.ApplicationService
{
    public class ProductAppService : ServiceBase, IProductAppService
    {
        private readonly IProductRepository _productRepository;

        public ProductAppService(IProductRepository productRepository, IUnitOfWork uow) : base(uow)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Get()
        {
            return _productRepository.Get();
        }

        public Product Register(Product product)
        {
            product.RegisterIsValid();

            _productRepository.Register(product);

            Commit();

            return product;
        }
    }
}