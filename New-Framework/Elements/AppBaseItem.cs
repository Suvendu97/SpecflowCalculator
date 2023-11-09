
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using UnitTestProject1.appl;


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
            clickButton.Click();


        }

        public void doubleclick()
        {
            var ClickMenu = UIGetElement();
            ClickMenu.DoubleClick();
        }
    }

}



    
