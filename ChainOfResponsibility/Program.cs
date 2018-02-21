namespace ChainOfResponsibility
{
    using Entities;

    class Program
    {
        private static AbstractLogger getChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.setNextLogger(fileLogger);
            fileLogger.setNextLogger(consoleLogger);

            return errorLogger;
        }

        static void Main()
        {
            AbstractLogger loggerChain = getChainOfLoggers();

            loggerChain.LogMessage(AbstractLogger.INFO, "This is an information.");
            loggerChain.LogMessage(AbstractLogger.DEBUG, "This is an debug level information.");
            loggerChain.LogMessage(AbstractLogger.ERROR, "This is an error information.");
        }
    }
}