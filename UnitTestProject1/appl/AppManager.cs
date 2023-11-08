using Pilot_FrameWork.Utils.Configuration;
using SpecFlow.Internal.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace UnitTestProject1.appl
{
    public class AppManager
    {
        static Application application;
        // public Application application;

        public static void LanuchApp(string appname)
        {

            //path = "C:\\Program Files\\OldClassicCalc\\calc1.exe";
            //application = Application.Launch(path);
            var apppath = Configuration.path(appname);
            Console.WriteLine($"App Path is : {apppath}");

            application = Application.Launch(apppath);

        }

        public static AppWindow AppGetWindow(string title = "")
        {
            return new AppWindow(application.GetWindow(title == "" ? "Calculator" : title));
        }

    }
}
