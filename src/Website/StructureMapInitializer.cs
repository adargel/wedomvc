using StructureMap;
using Website.Registries;

namespace Website
{
    public static class StructureMapInitializer
    {
        public static void Initialize()
        {
            ObjectFactory.Initialize(x => x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.IncludeNamespaceContainingType<RunOnAppStartupRegistry>();
                    scan.LookForRegistries();
                }));
        }
    }
}