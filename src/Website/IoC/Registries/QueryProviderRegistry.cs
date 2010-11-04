using Domain.Queries.Providers;
using Storage.QueryProviders;
using StructureMap.Configuration.DSL;

namespace Website.IoC.Registries
{
    public class QueryProviderRegistry : Registry
    {
        public QueryProviderRegistry()
        {
            For<ICategoryQueryProvider>().Use<CategoryQueryProvider>();
            // or we can use the default conventions.
        }
    }
}