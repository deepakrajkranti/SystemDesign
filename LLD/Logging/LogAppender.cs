namespace LLD.Logging
{
    public interface LogAppender
    {
        void Append(LogMessage logMessage);
    }
}
