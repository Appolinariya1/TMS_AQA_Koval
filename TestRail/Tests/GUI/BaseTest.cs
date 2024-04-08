using OpenQA.Selenium;
using TestRailComplexApi.Core;
using TestRailComplexApi.Helpers.Configuration;
using TestRailComplexApi.Models;
using TestRailComplexApi.Steps;

namespace TestRailComplexApi.Tests.GUI;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }

    protected NavigationSteps _navigationSteps;
    protected ProjectSteps _projectSteps;

    protected User? Admin { get; private set; }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;

        _navigationSteps = new NavigationSteps(Driver);
        _projectSteps = new ProjectSteps(Driver);

        Admin = Configurator.Admin;
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}