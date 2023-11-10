
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using NUnit.Framework;
using UnitTestProject1.appl;
using Test.Form;
using Test.Configuration;


namespace SpecFlowProject10.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        CalculatorForm calculator = new CalculatorForm(SearchCriteria.All, "");

        [Given(@"Calculator is Opened")]
        public void GivenCalculatorIsOpened()
        {
            var path = Configuration.Path("calculator");
            AppManager.LanuchApp(path);
        }

        [When(@": I Select the Mode '([^']*)'")]
        public void WhenISelectTheMode(string mode)
        {
            calculator.EnterMode(mode);
        }

        [Then(@": I Input (.*)")]
        public void ThenIInput(int number)
        {
            string numb = number.ToString();
            calculator.EnterNumber(numb);
        }

        [Then(@": I perform '(.*)' action")]
        public void ThenIPerformAction(string action)
        {
            switch(action)
            {
                case "add":
                    calculator.EnterPlus();
                    break;
                case "equal":
                    calculator.EnterEqual();
                    break;
                case "StoreinMemory":
                    calculator.EnterMPlus();
                    break;
                case "Square":
                    calculator.EnterSquare();
                    break;
            }
        }

        [Then(@": The Result is '(.*)'")]
        public void ThenTheResultIs(string expectedResult)
        {
            var result = CalculatorForm.GetResult();
            Assert.AreEqual(expectedResult, result);
        }

    }
}
    
