using OpenQA.Selenium;
using PageObject.Core;
using PageObject.Helpers.Configuration;

namespace PageObject.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    
    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}