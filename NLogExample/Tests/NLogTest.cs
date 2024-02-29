using NLog;

namespace NLogExample.Tests;

[TestFixture]
public class NLogTest
{
    protected static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

    [Test]
    public void LevelsTest()
    {
        //trace - 0
        //debug - 1
        //information - 2
        //warn - 3
        //error - 4
        //fatal - 5
        //off - 6. Не используем

        Logger.Log(LogLevel.Info, "This is an information message...");

        Logger.Trace("Trace level...");
        Logger.Debug("Debug level...");
        Logger.Info("Info level...");
        Logger.Warn("Warn level...");
        Logger.Error("Error level...");
        Logger.Fatal("Fatal level...");
    }

    [Test]
    public void ExceptionLogTest()
    {
        try
        {
            throw new AssertionException("Какая-то ошибка");
        }
        catch (Exception e)
        {
            Logger.Error(e, "Логируем ошибку");
        }
    }
}