using System.Web.Http;
using Unity;
using CoinTree.Helpers;
using CoinTree.Interfaces;

namespace CoinTree
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            var container = new UnityContainer();
            container.RegisterType<ICoinTreeWebClient, CoinTreeWebClient>();
            container.RegisterType<ILoggerManager, LoggerManager>();
            config.DependencyResolver = new UnityResolver(container);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
