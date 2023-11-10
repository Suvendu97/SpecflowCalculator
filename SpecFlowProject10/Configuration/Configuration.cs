using NLog;
using New_Framework.Logs;

namespace Test.Configuration

{
    public class Configuration

    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        static string[] configFileLines;
        public static string Path(string appname)
        {
            try
            {
                var currentPath = Directory.GetCurrentDirectory();
                var absolutepath = $"{currentPath}/../../../Configuration/AppConfig.txt";
                configFileLines = File.ReadAllLines(absolutepath);

                var app1Path = GetPath(appname);
                NLogger.Log("Info", $"Path is {app1Path}");
                return app1Path;
            }
            catch (Exception ex)
            {
                NLogger.Log("Error", $"Error reading configuration file: {ex.Message}");
                //Logger.Error($"Error reading configuration file: {ex.Message}");
                return null;
            }
        }
        static string GetPath(string appName)
        {
            try
            {
                foreach (var line in configFileLines)
                {
                    if (line.Contains($"{appName} Path:"))
                    {
                        var result = line.Replace($"{appName} Path: ", "");
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


