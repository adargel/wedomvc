namespace Website.Startup
{
    public class AppStartupRunner
    {
        readonly IRunOnAppStartup[] _needsToRunOnStartup;

        public AppStartupRunner(IRunOnAppStartup[] needsToRunOnStartup)
        {
            _needsToRunOnStartup = needsToRunOnStartup;
        }

        public void Run()
        {
            foreach(var instance in _needsToRunOnStartup)
                instance.Run();
        }
    }
}