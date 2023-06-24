namespace ConsoleApp1.Utils;

using NLog;
using NLog.Config;
using NLog.Targets;
using NUnit.Framework;

public sealed class Logger
{
    private static readonly Lazy<Logger> LazyInstance = new(() => new Logger());

    private readonly ILogger _log = LogManager.GetLogger(Thread.CurrentThread.ManagedThreadId.ToString());

    private Logger()
    {
        try
        {
            LogManager.LoadConfiguration("NLog.config");
        }
        catch (FileNotFoundException)
        {
            LogManager.Configuration = GetConfiguration();
        }
    }

    private LoggingConfiguration GetConfiguration()
    {
        string layoutName = "${date:format=yyyy-MM-dd HH\\:mm\\:ss} ${level:uppercase=true} - ${message}";
        LoggingConfiguration configuration = new LoggingConfiguration();
        
        LogLevel debug = LogLevel.Debug;
        LogLevel fatal2 = LogLevel.Fatal;
        FileTarget fileTarget = new FileTarget("logfile");
        fileTarget.DeleteOldFileOnStartup = false;

        var testName = TestContext.CurrentContext.Test.Name;
        var testId = TestContext.CurrentContext.Test.ID;

        fileTarget.FileName = @$"../../../Log/{testName}_{testId}.log";
        fileTarget.Layout = layoutName;
        configuration.AddRule(debug, fatal2, fileTarget);
        return configuration;
    }

    public static Logger Instance => LazyInstance.Value;

    public void Info(string message) => _log.Info(message);

    public void Warn(string message) => _log.Warn(message);

    public void Error(string message) => _log.Error(message);
}