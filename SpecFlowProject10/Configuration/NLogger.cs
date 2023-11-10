using NLog;


namespace Test.Configuration
{
    
    public static class NLogger
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        public static void Log(string logLevel, string message)
        {

            switch (logLevel)
            {
                case "Info":
                    Logger.Info(message);
                    break;
                case "Error":
                    Logger.Error(message);
                    break;
                case "Warn":
                    Logger.Warn(message);
                    break;
                case "Debug":
                    Logger.Debug(message);
                    break;
            } 
        }
    }
    
}
