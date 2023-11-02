using SpecFlow.Internal.Json;
using System;
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



        public static void LanuchApp(string path)
        {

            path = "C:\\Program Files\\OldClassicCalc\\calc1.exe";
            application = Application.Launch(path);

        }

        public static AppWindow AppGetWindow(string title = "")
        {
            //  title == "" ? "Calculator" :title
            /*
             * if (condition)
             * {
             * } 
             * else 
             * {
             * }
             * condition ? r1 : r2
            */

            return new AppWindow(application.GetWindow(title == "" ? "Calculator" : title));
        }

       

        








        /*
       public void windowcapture(string title)

       {
           window = application.GetWindow(title, InitializeOption.NoCache);

       }

*/



    }
}
