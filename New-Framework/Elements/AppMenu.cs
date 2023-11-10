using Gherkin.Ast;
using TestStack.White.UIItems.Finders;

namespace UnitTestProject1.Elements
{
    public class AppMenu : AppBaseItem
    {

        public AppMenu(SearchCriteria searchCriteria, string friendlyname) : base(searchCriteria, friendlyname)
        {

        }
        public void ClickMenuItem(string Mode)
        {
            Doubleclick();

            AppMenu clickscientific = new AppMenu(SearchCriteria.ByText(Mode), "Mode");
            clickscientific.Click();
        }
    }
}



