
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using UnitTestProject1.appl;
using NLog;
using System;
using New_Framework.Logs;

namespace UnitTestProject1.Elements
{
    public class AppBaseItem
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        static SearchCriteria _searchCriteria;
        private string _friendlyname;
        public AppBaseItem(SearchCriteria searchCriteria, string friendlyname)
        {
            _searchCriteria = searchCriteria;
            _friendlyname = friendlyname;

        }

        public  IUIItem UIGetElement(   )
        {
            try
            {
                return AppManager.AppGetWindow().appWindow.Get(_searchCriteria);
            }
            catch (Exception ex)
            {
                Logger.Error($"Error retrieving UI element {_friendlyname}: {ex.Message}");
                return null;
            }

        }
        public void Click()
        {
            try
            {
                var clickButton = UIGetElement();
                clickButton.Click();
                NLogger.Log("Info", $"{_friendlyname} element was clicked");


            }
            catch (Exception ex)
            {
                NLogger.Log("Error", $"Error clicking {_friendlyname} button: {ex.Message}");
            }
        }

        public void Doubleclick()
        {
            try
            {
                NLogger.Log("Info", $"Double-clicked {_friendlyname} element successfully.");
                var element = UIGetElement();
                element.DoubleClick();

            }
            catch (Exception ex)
            {
                NLogger.Log("Error", $"Error double-clicking {_friendlyname} element: {ex.Message}");
            }
        }
    }

}



    
