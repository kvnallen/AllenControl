using System.Web.Http;
using Microsoft.Owin;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using SimpleInjector;

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

        }

        private void ConfigureDependencyInjection(HttpConfiguration config, Container container)
        {
            var options = container.Options;

            
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
