using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WPFUIItems;
using UnitTestProject1.appl;
using TestStack.White;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.ScreenObjects.ScreenAttributes;
using TestStack.White.Factory;
using Button = TestStack.White.UIItems.Button;
using Menu = TestStack.White.UIItems.MenuItems.Menu;

namespace UnitTestProject1.Elements
{
    public class AppBaseItem
    {
        static SearchCriteria _searchCriteria;
        private string _friendlyname;
        public AppBaseItem(SearchCriteria searchCriteria, string friendlyname)
        {
            _searchCriteria = searchCriteria;
            _friendlyname = friendlyname;

        }


        public  IUIItem UIGetElement(   )
        {

            return AppManager.AppGetWindow().appWindow.Get(_searchCriteria);
            
        }
        public void Click()
        {
            var clickButton = UIGetElement();
           // clickButton.Get(SearchCriteria.ByAutomationId())
            clickButton.Click();


        }

        public void doubleclick()
        {
            var ClickMenu = UIGetElement();
            ClickMenu.DoubleClick();
        }





        // var viewStandard = (Menu)UIGetElement().Get(SearchCriteria.ByText("Scientific"));
        // viewStandard.Click();
        //AppBase.UIMenu(searchCriteria,"Calculator").Click();

        // var viewHelp = _mainWindow.Get<Menu>(SearchCriteria.ByText("View Help"));
    }

}



    
