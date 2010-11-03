using System.Web.Mvc;
using StructureMap.Configuration.DSL;
using Website.Controllers;

namespace Website.Registries
{
    public class ControllerRegistry : Registry
    {
        public ControllerRegistry()
        {
            Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.IncludeNamespaceContainingType<CategoryController>();
                    scan.AddAllTypesOf<Controller>();
                });
        }
    }
}