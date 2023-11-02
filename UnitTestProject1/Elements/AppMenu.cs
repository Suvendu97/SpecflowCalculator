using TestStack.White.UIItems.Finders;
using UnitTestProject1.appl;
using TestStack.White;
using TestStack.White.UIItems.WPFUIItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.ScreenObjects.ScreenAttributes;
using System.Linq;
using System.Windows.Controls;

namespace UnitTestProject1.Elements
{
    public class AppMenu : AppBaseItem
    {


        public AppMenu(SearchCriteria searchCriteria, string friendlyname) : base(searchCriteria, friendlyname)
        {

        }
        public void ClickMenuItem()
        {
            //var clickstandard = ((Menu)UIGetElement());
            // clickstandard.Click();

        }

    }
}
// private CustomWindow _calWindow;
/*
        public void CmenuItem(string menutext, CustomWindow _calWindow)
        {
            var value = _calWindow.cwindow.BaseButton(SearchCriteria.ByText(menutext)).Click();
            BaseButton(ByText, _calWindow);


        }

    }

*/


