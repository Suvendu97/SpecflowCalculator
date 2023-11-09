
using System;
using TestStack.White;

namespace UnitTestProject1.appl
{
    public class AppManager
    {
        static Application application;
        // public Application application;

        public static void LanuchApp(string appPath)
        {

            //path = "C:\\Program Files\\OldClassicCalc\\calc1.exe";
            //application = Application.Launch(path);
            //var apppath = Configuration.path(appname);
            //Console.WriteLine($"App Path is : {apppath}");

            application = Application.Launch(appPath);

        }

        public static AppWindow AppGetWindow(string title = "")
        {
            return new AppWindow(application.GetWindow(title == "" ? "Calculator" : title));
        }

    }
}
