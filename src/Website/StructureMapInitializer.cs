using Domain.Storage;
using Storage;
using StructureMap;

namespace Website
{
    public class StructureMapInitializer
    {
        public static void Initialize()
        {
            ObjectFactory.Initialize(x => x.For(typeof(IRepository<>)).Use(typeof(EfRepository<>)));
        }
    }
}