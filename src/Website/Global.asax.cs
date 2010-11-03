﻿using System.Web.Mvc;
using System.Web.Routing;
using Domain.Storage;
using Storage;
using StructureMap;
using Website.Controllers;

namespace Website
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
            StructureMapInitializer.Initialize();
            System.Web.Mvc.ControllerBuilder.Current.SetControllerFactory(new InjectingControllerFactory());
        }


    }
}