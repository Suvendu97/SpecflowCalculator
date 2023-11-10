
using Test.Hooks;

namespace UnitTestProject1.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private readonly ProcessesHelpers processes = new ProcessesHelpers();
        string appname = "calc1";
        [BeforeScenario("@closeAllInstances")]
        public void BeforeScenarioWithTag()
        {
            processes.KillMultipleInstancesOfProcess(appname);
        }
    }
}