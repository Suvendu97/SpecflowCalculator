
using System;
using TestStack.White;
using NLog;
using New_Framework.Logs;

namespace UnitTestProject1.appl
{
    public class AppManager
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        static Application application;

        public static void LanuchApp(string appPath)
        {
            try
            {
                NLogger.Log("Info", $"Application launched successfully.");
                application = Application.Launch(appPath);

            }
            catch (Exception ex)
            {
                NLogger.Log("Error", $"Error launching application : {ex.Message}");
            }

        }

        public static AppWindow AppGetWindow(string title = "")
        {

            try
            {
                return new AppWindow(application.GetWindow(title == "" ? "Calculator" : title));
            }
            catch (Exception ex)
            {
                NLogger.Log("Error", $"Error getting the application window: {ex.Message}");
                return null;
            }
        }

    }
}
