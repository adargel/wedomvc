using StructureMap;
using Website.ModelBinders;

namespace Website.Startup
{
    public class ModelBinderConfiguration : IRunOnAppStartup
    {
        public void Run()
        {
            System.Web.Mvc.ModelBinders.Binders.DefaultBinder = ObjectFactory.GetInstance<SmartModelBinder>();
        }
    }
}