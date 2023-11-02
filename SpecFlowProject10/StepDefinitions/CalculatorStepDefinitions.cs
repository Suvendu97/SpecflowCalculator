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
using UnitTestProject1.CalculatorVar;
using TestStack.White.UIItems.WPFUIItems;
using Test.Form;

namespace SpecFlowProject10.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        Customvar calculatorvar1 = new Customvar();

        [Given(@": Open  Calculator Application and")]
        public void GivenOpenCalculatorApplicationAnd()
        {

            string path = calculatorvar1.calpath();// All variable class
                                                   //  var appmanage = new CalculatorApp(path);// Applcation class Call the application
            AppManager.LanuchApp("Calculator");

            // Button button= AppManager.AppGetWindow().cwindow.Get<Button>(SearchCriteria.ByAutomationId("131")); 

        }

        [Given(@": Click on View Menu and select the Standard Option")]
        public void GivenClickOnViewMenuAndSelectTheStandardOption()
        {


            //  AppMenu clickonview= new AppMenu(SearchCriteria.ByText("view"), "view");
            //  clickonview.ClickCButtonItem();

            //AppButtons calbuttoon = new AppButtons(SearchCriteria.ByAutomationId("131"), "number1");

            // calbuttoon.ClickCButtonItem();
            // calbuttoon.ClickCButtonItem();
            //Button button = AppManager.AppGetWindow().cwindow.Get<Button>(SearchCriteria.ByAutomationId("131"));
            CalculatorForm calculator = new CalculatorForm(SearchCriteria.All, "");
            calculator.EnterNumber("12");
            calculator.EnterOperator("+");
            calculator.EnterNumber("999");
            calculator.EnterOperator("=");
            calculator.EnterOperator("M+");
            calculator.EnterOperator("+");
            calculator.EnterNumber("19");
            calculator.EnterOperator("=");

        }


    }
    }
/*
            //openeing the calculator app
            // Class1 class1 = Class1.Getinstance();
            appl.LaunchApplication("C:\\Program Files\\OldClassicCalc\\calc1.exe", "Calculator");

            appl.Menu_view("View");
            appl.Manu_Scentific("Standard");
            
            
           
        }







        [Then(@"Input (.*) and click on add")]
        public void ThenInputAndClickOnAdd(int p0)
        {
            //addation of numbers
            //Class1 class1 = Class1.Getinstance();
           appl.Btnoperation_Automationid("131");
            appl.Btnoperation_Automationid("132");
            appl    .Btnoperation_Automationid("93");


        }

        [Then(@"Input (.*)  and check the result")]
        public void ThenInputAndCheckTheResult(int p0)
        {
            //add the number  
           // Class1 class1 = Class1.Getinstance();
            appl.Btnoperation_Automationid("139");
            appl.Btnoperation_Automationid("139");
            appl.Btnoperation_Automationid("139");
            appl.Btnoperation_Automationid("121");
        }

        [Then(@"Click on save result")]
        public void ThenClickOnSaveResult()
        {
            //m+ operation
         //   Class1 class1 = Class1.Getinstance();
            appl.Btnoperation_Automationid("125");
            appl.Btnoperation_Automationid("93");

        }

        [Then(@"click on Add and Input (.*)")]
        public void ThenClickOnAddAndInput(int p0)
        {
           // Class1 class1 = Class1.Getinstance();
            appl.Btnoperation_Automationid("131");
            appl.Btnoperation_Automationid("139");
            appl.Btnoperation_Automationid("121");
            //class1.Btnoperation_Automationid("158");

            Thread.Sleep(3000);
            //views


            appl.closeapp();
        }

        [Then(@"click of result")]
        public void ThenClickOfResult()
        {
            // Class1 class1 = Class1.Getinstance();
            appl.Btnoperation_Automationid("125");
        }

        








    }



}
*/
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

















