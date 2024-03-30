using OpenQA.Selenium;
using SauceDemoHW.Core;
using SauceDemoHW.Helpers;
using SauceDemoHW.Helpers.Configuration;

namespace SauceDemoHW.Tests;

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