
using System;
using TestStack.White;

namespace UnitTestProject1.appl
{
    public class AppManager
    {
        static Application application;

        public static void LanuchApp(string appPath)
        {
            application = Application.Launch(appPath);

        }

        public static AppWindow AppGetWindow(string title = "")
        {
            return new AppWindow(application.GetWindow(title == "" ? "Calculator" : title));
        }

    }
}
