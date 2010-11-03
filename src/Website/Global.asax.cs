﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;
using Website.Startup;

namespace Website
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
        }

        protected void Application_Start()
        {
            StructureMapInitializer.Initialize();
            ObjectFactory.GetInstance<AppStartupRunner>().Run();

            RegisterRoutes(RouteTable.Routes);

        }
    }
}