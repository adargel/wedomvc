using StructureMap.Configuration.DSL;
using Website.Startup;

namespace Website.IoC.Registries
{
    public class RunOnAppStartupRegistry : Registry
    {
        public RunOnAppStartupRegistry()
        {
            Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.IncludeNamespaceContainingType<IRunOnAppStartup>();
                    scan.AddAllTypesOf<IRunOnAppStartup>();
                });
        }
    }
}