using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;
using NUnit.Framework;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.Factory;

namespace CalculatorApp.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given(@"Close all Instances")]
        public void GivenCloseAllInstances()
        {

        }

        [Then(@"Open the Calculator")]
        public void ThenOpenTheCalculator()
        {
            var CalculatorPath = @"C:\Program Files\OldClassicCalc\calc1.exe";
            //var CalculatorPath1 = Path.Combine(C:\Users\conspol\Downloads\oldcalcWin11Win10, "OldClassicCalc-2.0-setup.exe");
            TestStack.White.Application CalculatorApp = TestStack.White.Application.Launch(CalculatorPath);


            // Window CalculatorWindow = CalculatorApp.GetWindow("CalculatorApp");
            Window CalculatorWindow = CalculatorApp.GetWindow("Calculator", InitializeOption.NoCache);

            Button Number0 = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("130"));
            Button Number1 = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("131"));
            Button Number2 = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("132"));
            Button Number3 = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("133"));
            Button Number4 = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("134"));
            Button Number5 = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("135"));
            Button Number6 = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("136"));
            Button Number7 = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("137"));
            Button Number8 = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("138"));
            Button Number9 = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("139"));

            Button Devide = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("91"));
            Button Multiple = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("92"));
            Button Plus = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("93"));
            Button Minus = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("94"));

            Button Equal = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("121"));
            Button MC = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("122"));
            Button MR = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("123"));
            Button MS = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("124"));
            Button Mplus = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("125"));
            Button Mminus = CalculatorWindow.Get<Button>(SearchCriteria.ByAutomationId("126"));

            Number1.Click();
            Number2.Click();
            Plus.Click();
            Number9.Click();
            Number9.Click();
            Number9.Click();
            Equal.Click();
            Mplus.Click();
            Plus.Click();
            Number1.Click();
            Number9.Click();
            Equal.Click();

        }

        [Then(@"Add Numbers")]
        public void ThenAddNumbers()
        {
            
        }






    }
}