using StructureMap;
using Website.IoC.Registries;

namespace Website
{
    public class StructureMapInitializer
    {
        public static void Initialize()
        {
            ObjectFactory.Initialize(x => x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.IncludeNamespaceContainingType<RepositoryRegistry>();
                    scan.LookForRegistries();
                }));
        }
    }
}