using AllenControl.ApplicationService;
using AllenControl.Core.Stock.Repositories;
using AllenControl.Core.Stock.Services;
using AllenControl.Infra.Persistence.DataContexts;
using AllenControl.Infra.Repositories;
using AllenControl.Infra.Transaction;
using DomainNotificationHelper;
using DomainNotificationHelper.Events;
using SimpleInjector;

namespace AllenControl.CrossCutting
{
    public static class RegisterHelper
    {
        public static void Register(Container container)
        {
            container.Register<IProductRepository, ProductRepository>(Lifestyle.Scoped);
            container.Register<IProductAppService, ProductAppService>(Lifestyle.Scoped);

            container.Register<ICategoryAppService, CategoryAppService>(Lifestyle.Scoped);
            container.Register<ICategoryRepository, CategoryRepository>(Lifestyle.Scoped);

            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<AllenControlDbContext>(Lifestyle.Scoped);
            container.Register<IHandler<DomainNotification>, DomainNotificationHandler>(Lifestyle.Scoped);
        }
    }
}