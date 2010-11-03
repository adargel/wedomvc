using Machine.Specifications;
using StructureMap;

namespace Website.Tests.Unit
{
    public class When_configuring_structure_map
    {
        Because of = StructureMapInitializer.Initialize;

        It contains_a_valid_configuration = ObjectFactory.AssertConfigurationIsValid;
    }
}