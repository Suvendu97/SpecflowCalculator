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

        [Given(@": Open  Calculator Application and")]
        public void GivenOpenCalculatorApplicationAnd()
        {
            string path = Configuration.path("calculator");
            //Console.WriteLine($"calculator path is {path}");
            AppManager.LanuchApp(path);

        }

        [Given(@": Click on View Menu and select the Standard Option")]
        public void GivenClickOnViewMenuAndSelectTheStandardOption()
        {
            calculator.EnterMode("Standard");
        }

        [Then(@": Perform Operations in Standard Mode")]
        public void ThenPerformOperationsInStandardMode()
        {
            calculator.EnterNumber("12");
            calculator.EnterPlus();
            calculator.EnterNumber("999");
            calculator.EnterEqual();
            calculator.EnterMPlus();
            calculator.EnterPlus();
            calculator.EnterNumber("19");
            calculator.EnterEqual();
        }

        [Then(@":  Click on View Menu and select the Scientific Option")]
        public void ThenClickOnViewMenuAndSelectTheScientificOption()
        {
            calculator.EnterMode("Scientific");
        }

        [Then(@": Perform Operations in Scientific Mode")]
        public void ThenPerformOperationsInScientificMode()
        {
            calculator.EnterNumber("12");
            calculator.EnterPlus();
            calculator.EnterNumber("999");
            calculator.EnterEqual();
            calculator.EnterMPlus();
            calculator.EnterPlus();
            calculator.EnterNumber("19");
            calculator.EnterSquare();
        }

        [Then(@": Result Should Be (.*)")]
        public void ThenResultShouldBe(int p0)
        {
            string expectedValue = p0.ToString();
            bool compareReslt = calculator.CompareResult(expectedValue);
            if (compareReslt==true)
            {
                Console.WriteLine("The obtained result matches the expected value.");
            }
            else
            {
                Console.WriteLine("The obtained result does not match the expected value.");
            }

        }



    }
}
    
