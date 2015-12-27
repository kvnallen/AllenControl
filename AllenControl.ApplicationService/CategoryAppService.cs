using System.Collections.Generic;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Repositories;
using AllenControl.Core.Stock.Services;
using AllenControl.Infra.Transaction;

namespace AllenControl.ApplicationService
{
    public class CategoryAppService : ServiceBase, ICategoryAppService
    {
        private readonly ICategoryRepository _repository;

        public CategoryAppService(ICategoryRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = repository;
        }

        public IEnumerable<Category> Get()
        {
            return _repository.Get();
        }

        public Category Enable(string id)
        {
            throw new System.NotImplementedException();
        }

        public Category Disable(string id)
        {
            throw new System.NotImplementedException();
        }

        public Category Register(string title)
        {
            var category = new Category(title);
            category.Register();

            _repository.Register(category);

            Commit();

            return category;
        }
    }
}