using Rhino.Mocks;

namespace Website.Tests.Unit.StartupSpecs
{
    public class SpecsBase
    {
        protected static T M<T>() where T: class
        {
            return MockRepository.GenerateMock<T>();
        }
    }
}