using System.Web.Mvc;
using Domain.Storage;
using Storage;
using StructureMap;
using Website.Controllers;

namespace Website
{
    public class StructureMapInitializer
    {
        public static void Initialize()
        {
            ObjectFactory.Initialize(x =>
                {
                    x.For(typeof (IRepository<>)).Use(typeof (EfRepository<>));
                    x.Scan(scan =>
                        {
                            scan.TheCallingAssembly();
                            scan.IncludeNamespaceContainingType<HomeController>();
                            scan.AddAllTypesOf<Controller>();
                        });
                });
        }
    }
}