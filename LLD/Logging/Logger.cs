namespace LLD.Logging
{
    public class Logger
    {

        public static readonly Logger Instance = new Logger();
        private LoggerConfig _config;


        private Logger()
        {
            _config = new LoggerConfig(LogLevel.INFO, new ConsoleAppender());
        }

        //getinstance of logger
        public static Logger GetInstance()
        {
            return Instance;
        }


        public void SetConfig(LoggerConfig config)
        {
            _config = config;
        }

        public void Log(LogLevel level, string message)
        {
            if (level < _config.LogLevel)
            {
                return;
            }
            else
            {
                _config.LogAppender.Append(new LogMessage(level, message));
            }
        }

        public void LogInfo(string message)
        {
            Log(LogLevel.INFO, message);
        }

        public void LogError(string message)
        {
            Log(LogLevel.ERROR, message);
        }
        public void LogWarning(string message) {
            Log(LogLevel.WARNING, message);
        }

        public void LogDebug(string message)
        {
            Log(LogLevel.DEBUG, message);
        }
        public void LogFatal(string message) {
            Log(LogLevel.FATAL, message);
        }
        public void LogTrace(string message)
        {
            Log(LogLevel.Trace, message);
        }

    }
}
