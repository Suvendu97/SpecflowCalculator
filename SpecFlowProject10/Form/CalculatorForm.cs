
using TestStack.White.UIItems.Finders;
using UnitTestProject1.Elements;
using NLog;

namespace Test.Form
{

    public class CalculatorForm : AppBaseItem
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        private AppButtons ButtonPlus => new AppButtons(SearchCriteria.ByAutomationId("93"), "Number");
        private AppButtons ButtonMPlus => new AppButtons(SearchCriteria.ByAutomationId("125"), "Number");
        private AppButtons ButtonEqual => new AppButtons(SearchCriteria.ByAutomationId("121"), "Number");
        private AppButtons ButtonSquare => new AppButtons(SearchCriteria.ByAutomationId("111"), "Number");

        public CalculatorForm(SearchCriteria searchCriteria, string friendlyname) : base(searchCriteria, friendlyname)
        {
        }
        public AppButtons GetButton(string number)
        {
            return new AppButtons(SearchCriteria.ByAutomationId($"13{number}"), "number");

        }
  
        public void EnterNumber(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                var value = Char.ToString(number[i]);
                AppButtons button = GetButton(value);
                button.Click();
            }
        }

        public void EnterPlus() {
            ButtonPlus.Click();
        }
        public void EnterMPlus()
        {
            ButtonMPlus.Click();
        }
        public void EnterEqual()
        {
            ButtonEqual.Click();
        }
        public void EnterSquare()
        {
            ButtonSquare.Click();
        }

        public void EnterMode(string Mode)
        {
            AppMenu ClickView = new AppMenu(SearchCriteria.ByText("View"), "Option");
            ClickView.ClickMenuItem(Mode);
        }

    }

}
    


    






            

        