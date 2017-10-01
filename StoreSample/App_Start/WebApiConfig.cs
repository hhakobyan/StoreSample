using Microsoft.Practices.Unity.Mvc;
using StoreSample.App_Start;
using System.Web.Http;

namespace StoreSample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // TODO: Add any additional configuration code.

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.DependencyResolver = new UnityResolver(UnityConfig.GetConfiguredContainer());
        }
    }
}