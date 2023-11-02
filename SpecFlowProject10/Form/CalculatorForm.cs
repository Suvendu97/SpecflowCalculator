using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.Utility;
using UnitTestProject1.Elements;


namespace Test.Form
{

    public class CalculatorForm : AppBaseItem
    {


        // private string one1=Getautoids("1");
        private AppButtons button1 = new AppButtons(SearchCriteria.ByAutomationId("131"), "Number1");

        public CalculatorForm(SearchCriteria searchCriteria, string friendlyname) : base(searchCriteria, friendlyname)
        {
        }
        public string GetNumber(string value)
        {

            return "13" + value;
        }


        public void EnterNumber(string operation)
        {
            //  AppButtons calbuttoon = new AppButtons();
            //   calbuttoon.ClickCButtonItem();
            // AppBaseItem.ClickButtonItem("131");
            // AppBaseItem.Click(SearchCriteria.ByAutomationId("131"));
            // AppBaseItem.Click(SearchCriteria.ByAutomationId("131"));
            // button1.Click();



            // this for Buttons
            char[] EachButtons = new char[operation.Length];//12+999

            // Copy character by character into array 
            for (int i = 0; i < operation.Length; i++)
            {
                EachButtons[i] = operation[i];// 12+999
            }
            foreach (Char c in EachButtons)
            {

                //string  button="button"+c.ToString();// button1,2
                string value = Char.ToString(c);
                string id = GetNumber(value);

                AppButtons button = new AppButtons(SearchCriteria.ByAutomationId(id), "Number1");
                button.Click();

            }

        }

        public void EnterOperator(string Operator) 
        {
            string  id = "";
            if (Operator == "+")
            {
                id = "93";
            }

            else if (Operator == "-")
            {
                id = "94";
            }

            else if (Operator == "*")
            {
                id = "92";
            }

            else if (Operator == "/")
            {
                id = "91";
            }

            else if (Operator == "=")
            {
                id = "121";
            }

            else if (Operator == "MC")
            {
                id = "122";
            }
            else if (Operator == "M+")
            {
                id = "125";
            }
            else if (Operator == "M-")
            {
                id = "126";
            }
            AppButtons button = new AppButtons(SearchCriteria.ByAutomationId(id), "Number1");
            button.Click();

            

        }

    }

}
    


    






            

        