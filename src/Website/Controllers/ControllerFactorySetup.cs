using Website.Startup;

namespace Website.Controllers
{
    public class ControllerFactorySetup : IRunOnAppStartup
    {
        public void Run()
        {
            System.Web.Mvc.ControllerBuilder.Current.SetControllerFactory(new InjectingControllerFactory());
        }
    }
}