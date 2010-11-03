using Website.Controllers;

namespace Website.Startup
{
    public class ControllerFactorySetup : IRunOnAppStartup
    {
        public void Run()
        {
            System.Web.Mvc.ControllerBuilder.Current.SetControllerFactory(new InjectingControllerFactory());
        }
    }
}