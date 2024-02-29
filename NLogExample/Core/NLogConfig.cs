using NLog;

namespace NLogExample.Core;

public class NLogConfig
{
    public void Config()
    {
        var config = new NLog.Config.LoggingConfiguration();

        // Targets where to log to: File and Console
        var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
        var logfile = new NLog.Targets.FileTarget("logfile")
        {
            FileName = "file.txt",
            Layout = "${longdate}|${level:uppercase=true}|${logger}|${threadid}|${message}|${exception:format=tostring}"
        };

        // Rules for mapping loggers to targets            
        config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
        config.AddRule(LogLevel.Trace, LogLevel.Fatal, logfile);

        // Apply config           
        LogManager.Configuration = config;
    }
}