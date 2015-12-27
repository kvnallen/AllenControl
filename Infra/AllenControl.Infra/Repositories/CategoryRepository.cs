using System.Collections.Generic;
using System.Linq;
using AllenControl.Core.Stock.Entities;
using AllenControl.Core.Stock.Repositories;
using AllenControl.Infra.Persistence.DataContexts;

namespace AllenControl.Infra.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AllenControlDbContext _context;

        public CategoryRepository(AllenControlDbContext context)
        {
            _context = context;
        }

        public void Register(Category category)
        {
            _context.Categories.Add(category);
        }

        public IEnumerable<Category> Get()
        {
            return _context.Categories.ToList();
        }
    }
}