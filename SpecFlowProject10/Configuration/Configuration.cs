using System;
using System.IO;
 
 
namespace Test.Configuration

{

    public class Configuration

    {

        static string[] configFileLines;

        public static string path(string appname)

        {

            string configFilePath = "C:\\Users\\conspol\\source\\repos\\CalculatorApp\\SpecflowCalculator\\UnitTestProject1\\Configuration\\AppConfig.txt";

            configFileLines = File.ReadAllLines(configFilePath); // Read and store the line

            var app1Path = GetPath(appname); // Access path for Application1

            var app1WindowName = GetWindowName(appname); // Access window name for Application

            Console.WriteLine($"Application 1 Path: {app1Path}");

            Console.WriteLine($"Application 1 Window Name: {app1WindowName}");

            return app1Path;

        }

        static string GetPath(string appName)

        {

            Console.WriteLine($" abcd {appName}");

            foreach (var line in configFileLines)

            {

                if (line.Contains($"{appName} Path:"))

                {

                    return line.Replace($"{appName} Path: ", "");

                }

            }

            return null; // Handle the case where the application name is not found

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

            return null; // Handle the case where the application name is not found

        }

    }



}


