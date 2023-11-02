using System;
using TechTalk.SpecFlow;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White.Factory;
using TestStack.White;
using System.Windows.Automation;
using NUnit.Framework;

using UnitTestProject1.appl;

namespace SpecFlowProject10.StepDefinitions
{
    [Binding]
    public class CalScentificStepDefinitions
    {
    }
}
        /*
       // Class1 class1 = Class1.Getinstance();
        appl1 appl = appl1.Getinstance();


        [Given(@"Open new Calculator Once its closed")]
        public void GivenOpenNewCalculatorOnceItsClosed()
        {
            appl.LaunchApplication("C:\\Program Files\\OldClassicCalc\\calc1.exe", "Calculator");
            
        }

        [Then(@"click on View Menu and select Scientific")]
        public void ThenClickOnViewMenuAndSelectScientific()
        {
            appl.Menu_view("View");
            appl.Manu_Scentific("Scientific");
        }

        [Then(@"click on  number (.*) and click on add")]
        public void ThenClickOnNumberAndClickOnAdd(int p0)
        {
            appl.Btnoperation_Automationid("131");
            appl.Btnoperation_Automationid("132");
            appl.Btnoperation_Automationid("93");
        }

        [Then(@"click and  Input  numebr (.*)  and check the result")]
        public void ThenClickAndInputNumebrAndCheckTheResult(int p0)
        {
            appl.Btnoperation_Automationid("139");
            appl.Btnoperation_Automationid("139");
            appl.Btnoperation_Automationid("139");
            appl.Btnoperation_Automationid("121");

        }

        [Then(@"Click on  the save result")]
        public void ThenClickOnTheSaveResult()
        {
            appl.Btnoperation_Automationid("125");
        }

        [Then(@"click on Add  button and Input (.*)")]
        public void ThenClickOnAddButtonAndInput(int p0)
        {
            appl.Btnoperation_Automationid("93");
            
            
        }

        [Then(@"click on the result")]
        public void ThenClickOnTheResult()
        {
            appl.Btnoperation_Automationid("121");
            Thread.Sleep(1000);
        }

        [Then(@"press Clear and check the Square root of (.*)")]
        public void ThenPressClearAndCheckTheSquareRootOf(int p0)
        {
            appl.Btnoperation_Automationid("82");
            appl.Btnoperation_Automationid("131");
            appl.Btnoperation_Automationid("139");
            appl.Btnoperation_Automationid("111");
        }


    }



}

/*
        [Given(@"Add  Numbers wit standerd Calculator")]
        public void GivenAddNumbersWitStanderdCalculator()
        {



            Class1 class1 = Class1.Getinstance();//Single Instance of Class
            class1.LaunchApplication("C:\\Program Files\\OldClassicCalc\\calc1.exe");
            class1.WindowCap("Calculator");
            
            
            
            






            /*
             var Calculatorpathpath = @"C:\Program Files\OldClassicCalc\calc1.exe";
              Application app = Application.Launch(Calculatorpathpath);
              Window calwindow = app.GetWindow("Calculator");
              Button buttonone = calwindow.Get<Button>(SearchCriteria.ByAutomationId("131"));
              buttonone.Click();

              Button buttontwo = calwindow.Get<Button>(SearchCriteria.ByAutomationId("132"));
              buttontwo.Click();

              Button buttonAdd = calwindow.Get<Button>(SearchCriteria.ByAutomationId("93"));
              buttonAdd.Click();

              Button buttonnine = calwindow.Get<Button>(SearchCriteria.ByAutomationId("139"));
              buttonnine.Click();
              Button buttonnine2 = calwindow.Get<Button>(SearchCriteria.ByAutomationId("139"));
              buttonnine2.Click();
              Button buttonnine3 = calwindow.Get<Button>(SearchCriteria.ByAutomationId("139"));
              buttonnine3.Click();
              Button buttonresult = calwindow.Get<Button>(SearchCriteria.ByAutomationId("121"));
              buttonresult.Click();
              Button buttonmem = calwindow.Get<Button>(SearchCriteria.ByAutomationId("125"));
              buttonmem.Click();

              Button buttonAdd1 = calwindow.Get<Button>(SearchCriteria.ByAutomationId("93"));
              buttonAdd1.Click();

              Button buttonone6 = calwindow.Get<Button>(SearchCriteria.ByAutomationId("131"));
              buttonone6.Click();
              Button buttonnine5 = calwindow.Get<Button>(SearchCriteria.ByAutomationId("139"));
              buttonnine5.Click();
              Button buttonresult1 = calwindow.Get<Button>(SearchCriteria.ByAutomationId("121"));
              buttonresult1.Click();
              Label checkresult = calwindow.Get<Label>(SearchCriteria.ByAutomationId("158"));
              string res = checkresult.Text;
              Assert.AreEqual("1031", res, "value doesnt match ");

            
         
        }
*/
/*
    [Then(@"Add Numbers with Scentific Calculator")]
    public void ThenAddNumbersWithScentificCalculator()
    {


        Class1 class1 = Class1.Getinstance();
        class1.LaunchApplication("C:\\Program Files\\OldClassicCalc\\calc1.exe");
        class1.WindowCap("Calculator");


        class1.Menu_view("View");
        class1.Manu_Scentific("Scientific");

        class1.Btnoperation_Automationid("131");
        class1.Btnoperation_Automationid("132");
        class1.Btnoperation_Automationid("93");
        class1.Btnoperation_Automationid("139");
        class1.Btnoperation_Automationid("139");
        class1.Btnoperation_Automationid("139");

        class1.Btnoperation_Automationid("121");

        class1.Btnoperation_Automationid("125");
        class1.Btnoperation_Automationid("93");
        class1.Btnoperation_Automationid("131");
        class1.Btnoperation_Automationid("139");
        class1.Btnoperation_Automationid("121");
        Thread.Sleep(1000);
        class1.closeapp();

    }



}



}
*/

















