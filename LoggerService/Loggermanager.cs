
using Contracts;
using NLog;

namespace LoggerService
{
    public class Loggermanager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public Loggermanager()
        {
                 
        }

        public void LogDebug(string message)
        {
            logger.Debug(message);
         }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogWarning(string message)
        {
            logger.Warn(message);
        }
    }
}