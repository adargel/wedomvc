using Domain.Model;
using StructureMap.Configuration.DSL;
using Website.IoC.Conventions;
using Website.ModelBinders;

namespace Website.IoC.Registries
{
    public class SmartModelBinderRegistry : Registry
    {
        public SmartModelBinderRegistry()
        {
            Scan(scanner =>
                {
                    scanner.TheCallingAssembly();
                    scanner.AssemblyContainingType<Entity>();
                    scanner.AddAllTypesOf<Entity>();
                    scanner.AddAllTypesOf<IFilteredModelBinder>();
                    scanner.Convention<EntityModelBinderConventions>();
                });
        }
    }
}