using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http;
using AllenControl.Api.DomainHelpers;
using AllenControl.CrossCutting;
using DomainNotificationHelper.Events;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

[assembly: OwinStartup(typeof(AllenControl.Api.Startup))]

namespace AllenControl.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            var container = new Container();

            ConfigureWebApi(config);
            ConfigureDependencyInjection(config, container);


            var corsPolicy = new CorsPolicy
            {
                AllowAnyMethod = true,
                AllowAnyHeader = true,
                AllowAnyOrigin = true
            };

            var corsOptions = new CorsOptions
            {
                PolicyProvider = new CorsPolicyProvider
                {
                    PolicyResolver = context => Task.FromResult(corsPolicy)
                }
            };

            app.UseCors(corsOptions);
            app.UseWebApi(config);
        }

        public void ConfigureDependencyInjection(HttpConfiguration config, Container container)
        {
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            RegisterHelper.Register(container);


            container.RegisterWebApiControllers(config);

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            DomainEvent.Container = new DomainContainer(config.DependencyResolver);

            container.Verify();
        }


        private void ConfigureWebApi(HttpConfiguration config)
        {
            var formatters = config.Formatters;
            config.Formatters.Remove(formatters.XmlFormatter);

            var jsonSettings = formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            jsonSettings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
        }
    }
}
