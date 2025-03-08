namespace LLD.Logging
{
    public class LoggingDemo
    {
        public static void Run()
        {
            Logger logger = Logger.GetInstance();
            //logger.Log(LogLevel.INFO, "Hello, World! WARNING");
            //logger.Log(LogLevel.ERROR, "Hello, World! ERROR");
            //logger.Log(LogLevel.FATAL, "Hello, World! FATAL");
            //logger.Log(LogLevel.DEBUG, "Hello, World! DEBUG");
            //logger.Log(LogLevel.WARNING, "Hello, World! WARNING");
            //logger.Log(LogLevel.Trace, "Hello, World! Trace");
           logger.LogInfo("Hello, World! INFO");
            logger.LogError("Hello, World! ERROR");
            logger.LogFatal("Hello, World! FATAL");
            logger.LogDebug("Hello, World! DEBUG");
            logger.LogWarning("Hello, World! WARNING");
            logger.LogTrace("Hello, World! Trace");


        }
    }
}
