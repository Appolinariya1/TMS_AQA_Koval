using NUnitTest.Core;
using OpenQA.Selenium;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests;

[TestFixture]
public class WebDriverTest
{
    [Test]
    public void SimpleDriverTest()
    {
        IWebDriver webDriver = new SimpleDriver().Driver;
        webDriver.Manage().Window.Maximize();
        webDriver.Navigate().GoToUrl("https://www.ikea.com/it/it/");
        webDriver.Quit(); //чтобы убить процессы после запуска, если было закрыто вручную
        //close - окно закроется, но сессия продолжится
        //quit - закроются и окна, и сессия
        
    }
    
    [Test]
    public void AdvancedDriverTest()
    {
        IWebDriver webDriver = new AdvancedDriver().GetChromeDriver();
        webDriver.Manage().Window.Maximize();
        webDriver.Navigate().GoToUrl("https://www.ikea.com/it/it/");
        webDriver.Quit();
    }
    
    [Test]
    public void FactoryDriverTest()
    {
        IWebDriver webDriver = new Browser().Driver;
        webDriver.Manage().Window.Maximize();
        webDriver.Navigate().GoToUrl("https://www.ikea.com/it/it/");
        webDriver.Quit();
    }
}