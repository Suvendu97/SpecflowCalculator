using System;
using TechTalk.SpecFlow;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White.Factory;
using TestStack.White;
using System.Windows.Automation;
using NUnit.Framework;
using UnitTestProject1.Elements;
using UnitTestProject1.appl;
using TestStack.White.UIItems.WPFUIItems;
using Test.Form;
using TechTalk.SpecFlow.CommonModels;
using Test.Configuration;


namespace SpecFlowProject10.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        CalculatorForm calculator = new CalculatorForm(SearchCriteria.All, "");
        string smode;

        [Given(@"Open the Calculator Application")]
        public void GivenOpenTheCalculatorApplication()
        {
            var path = Configuration.Path("calculator");
            AppManager.LanuchApp(path);
        }

        [Given(@": Select the Mode '(.*)'")]
        public void GivenSelectTheMode(string mode)
        {
            smode = mode;
            calculator.EnterMode(mode);
        }

        [Then(@": I Enter '(.*)' '(.*)' and perform add operation")]
        public void ThenIEnterAndPerformAddOperation(string numb1, string numb2)
        {
            calculator.EnterNumber(numb1);
            calculator.EnterPlus();
            calculator.EnterNumber(numb2);
            calculator.EnterEqual();
        }

        [Then(@": Then I Click M\+")]
        public void ThenThenIClickM()
        {
            calculator.EnterMPlus();
        }

        [Then(@": Use square root if its scientific '(.*)'")]
        public void ThenUseSquareRootIfItsScientific(string numb3)
        {
            if (smode == "Scientific")
            {
                calculator.EnterNumber(numb3);
                calculator.EnterSquare();
            }
            else
            {
                calculator.EnterPlus();
                calculator.EnterNumber(numb3);
                calculator.EnterEqual();
            }
        }

        [Then(@": The Result should be '([^']*)'")]
        public void ThenTheResultShouldBe(string numb4)
        {
            Label resultTextBox = AppManager.AppGetWindow().appWindow.Get<Label>(SearchCriteria.ByAutomationId("158"));
            var resultValue = resultTextBox.Text;
            Assert.AreEqual(numb4, resultValue);

        }

    }
}
    
