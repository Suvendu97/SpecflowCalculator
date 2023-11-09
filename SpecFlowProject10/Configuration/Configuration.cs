﻿using System;
using System.IO;
using NLog;

namespace Test.Configuration

{

    public class Configuration

    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        static string[] configFileLines;
        public static string path(string appname)
        {
            //string configFilePath = "C:\\Users\\conspol\\source\\repos\\final\\SpecflowCalculator\\SpecFlowProject10\\Configuration\\AppConfig.txt";
            //configFileLines = File.ReadAllLines(configFilePath);

            //var app1Path = GetPath(appname);
            /*for (int i = 0; i < configFileLines.Length; i++)
            {
                string lines = configFileLines[i];
                Console.WriteLine($"configline is {lines}");
            } */

            //var app1WindowName = GetWindowName(appname);
            //return app1Path;

            try
            {
                string configFilePath = "C:\\Users\\conspol\\source\\repos\\final\\SpecflowCalculator\\SpecFlowProject10\\Configuration\\AppConfig.txt";
                configFileLines = File.ReadAllLines(configFilePath);

                var app1Path = GetPath(appname);
                return app1Path;
            }
            catch (Exception ex)
            {
                Logger.Error($"Error reading configuration file: {ex.Message}");
                return null;
            }
        }
        static string GetPath(string appName)
        {
            /*foreach (var line in configFileLines)
            {
                if (line.Contains($"{appName} Path:"))
                {
                    string result = line.Replace($"{appName} Path: ", "");
                    return line.Replace($"{appName} Path: ", "");
                }
            }
            return null;
            */

            try
            {
                foreach (var line in configFileLines)
                {
                    if (line.Contains($"{appName} Path:"))
                    {
                        string result = line.Replace($"{appName} Path: ", "");
                        return line.Replace($"{appName} Path: ", "");
                    }
                }
                Logger.Warn($"Path for {appName} not found in the configuration file.");
                return null;
            }
            catch (Exception ex)
            {
                Logger.Error($"Error getting path for {appName}: {ex.Message}");
                return null;
            }
        }
        static string GetWindowName(string appName)
        {
            /*foreach (var line in configFileLines)
            {
                if (line.Contains($"{appName} WindowName:"))
                {
                    return line.Replace($"{appName} WindowName: ", "");
                }
            }
            return null; */

            try
            {
                foreach (var line in configFileLines)
                {
                    if (line.Contains($"{appName} WindowName:"))
                    {
                        return line.Replace($"{appName} WindowName: ", "");
                    }
                }
                Logger.Warn($"WindowName for {appName} not found in the configuration file.");
                return null;
            }
            catch (Exception ex)
            {
                Logger.Error($"Error getting window name for {appName}: {ex.Message}");
                return null;
            }
        }
    }
}


