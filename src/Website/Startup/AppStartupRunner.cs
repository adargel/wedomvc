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
            foreach(var item in _needsToRunOnStartup)
            {
                item.Run();
            }
        }
    }
}