using Machine.Specifications;
using Rhino.Mocks;
using Website.Startup;

namespace Website.Tests.Unit.StartupSpecs
{
    public class AppStartupRunnerSpecs : SpecsBase
    {
        static AppStartupRunner _runner;
        static IRunOnAppStartup[] _needsToRunOnStartup;

        Establish context = () =>
            {
                _needsToRunOnStartup = new[]
                {
                    M<IRunOnAppStartup>(),
                    M<IRunOnAppStartup>(),
                    M<IRunOnAppStartup>()
                };

                _runner = new AppStartupRunner(_needsToRunOnStartup);
            };

        Because of = ()=> _runner.Run();

        It runs_all_given_instances_of_run_on_app_startup = () =>
            {
                foreach (var i in _needsToRunOnStartup)
                    i.AssertWasCalled(x => x.Run());
            };
    }
}