using TechTalk.SpecFlow;
using Test.Form;

namespace UnitTestProject1.Hooks
{
    [Binding]
    public sealed class Hooks1
    {

        [BeforeScenario("@outline")]
        public void BeforeScenarioWithTag()
        {
            CalculatorForm.CloseInstanceOfApplication("calc1");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
    }
}