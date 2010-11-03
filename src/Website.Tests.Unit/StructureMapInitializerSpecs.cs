using Machine.Specifications;
using StructureMap;

namespace Website.Tests.Unit
{
    public class StructureMapInitializerSpecs
    {
        Because of = StructureMapInitializer.Initialize;

        It has_a_valid_configuration = ObjectFactory.AssertConfigurationIsValid;
    }
}