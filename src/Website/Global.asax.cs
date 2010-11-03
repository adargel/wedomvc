using StructureMap;
using Website.Startup;

namespace Website
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            StructureMapInitializer.Initialize();
            ObjectFactory.GetInstance<AppStartupRunner>().Run();
        }
    }
}