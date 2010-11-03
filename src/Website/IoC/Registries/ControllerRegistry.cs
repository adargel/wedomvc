using System.Web.Mvc;
using StructureMap.Configuration.DSL;
using Website.Controllers;

namespace Website.IoC.Registries
{
    public class ControllerRegistry : Registry
    {
        public ControllerRegistry()
        {
            Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.IncludeNamespaceContainingType<HomeController>();
                    scan.AddAllTypesOf<Controller>();
                });
        }
    }
}