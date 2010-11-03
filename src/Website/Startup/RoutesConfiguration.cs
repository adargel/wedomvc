using System.Web.Mvc;
using System.Web.Routing;

namespace Website.Startup
{
    public class RoutesConfiguration : IRunOnAppStartup
    {
        public void Run()
        {
            var routes = RouteTable.Routes;
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }
    }
}