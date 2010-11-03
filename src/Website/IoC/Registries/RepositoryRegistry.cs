using Domain.Storage;
using Storage;
using StructureMap.Configuration.DSL;

namespace Website.IoC.Registries
{
    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            For(typeof (IRepository<>)).Use(typeof (EfRepository<>));
        }
    }
}