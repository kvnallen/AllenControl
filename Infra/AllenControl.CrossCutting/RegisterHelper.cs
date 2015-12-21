using AllenControl.ApplicationService;
using AllenControl.Core.Stock.Repositories;
using AllenControl.Core.Stock.Services;
using AllenControl.Infra.Repositories;
using SimpleInjector;

namespace AllenControl.CrossCutting
{
    public static class RegisterHelper
    {
        public static void Register(Container container)
        {
            container.Register<IProductRepository, ProductRepository>(Lifestyle.Scoped);
            container.Register<IProductAppService, ProductAppService>(Lifestyle.Scoped);
        }
    }
}