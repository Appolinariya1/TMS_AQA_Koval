using Allure.Core;
using Allure.Helpers;
using Allure.Helpers.Configuration;
using Allure.Net.Commons;
using Allure.Steps;
using NUnit.Allure.Core;
using OpenQA.Selenium;

namespace Allure.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
[AllureNUnit]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected UserSteps UserSteps;

    [OneTimeSetUp]
    public static void GlobalSetUp()
    {
        AllureLifecycle.Instance.CleanupResultDirectory();
    }
    
    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        UserSteps = new UserSteps(Driver);
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}