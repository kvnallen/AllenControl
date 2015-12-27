using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using DomainNotificationHelper;

namespace AllenControl.Api.DomainHelpers
{
    public class DomainContainer : IContainer
    {
        private readonly IDependencyResolver _resolver;

        public DomainContainer(IDependencyResolver resolver)
        {
            _resolver = resolver;
        }

        public T GetService<T>()
        {
            return (T)_resolver.GetService(typeof (T));
        }

        public object GetService(Type serviceType)
        {
            return _resolver.GetService(serviceType);
        }

        public IEnumerable<T> GetServices<T>()
        {
            return (IEnumerable<T>)_resolver.GetService(typeof (T));
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _resolver.GetServices(serviceType);
        }
    }
}