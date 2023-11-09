using System;
using System.IO;
 
 
namespace Test.Configuration

{

    public class Configuration

    {
        static string[] configFileLines;
        public static string path(string appname)
        {
            string configFilePath = "C:\\Users\\conspol\\source\\repos\\final\\SpecflowCalculator\\SpecFlowProject10\\Configuration\\AppConfig.txt";
            configFileLines = File.ReadAllLines(configFilePath);

            var app1Path = GetPath(appname);
            for (int i = 0; i < configFileLines.Length; i++)
            {
                string lines = configFileLines[i];
                Console.WriteLine($"configline is {lines}");
            }

            var app1WindowName = GetWindowName(appname);
            return app1Path;
        }
        static string GetPath(string appName)
        {
            foreach (var line in configFileLines)
            {
                if (line.Contains($"{appName} Path:"))
                {
                    string result = line.Replace($"{appName} Path: ", "");
                    return line.Replace($"{appName} Path: ", "");
                }
            }
            return null;
        }
        static string GetWindowName(string appName)
        {
            foreach (var line in configFileLines)
            {
                if (line.Contains($"{appName} WindowName:"))
                {
                    return line.Replace($"{appName} WindowName: ", "");
                }
            }
            return null;
        }
    }
}


