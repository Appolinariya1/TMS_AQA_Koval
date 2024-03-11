using CoreProject.Core;
using CoreProject.Helpers.Configuration;
using CoreProject.Models;
using CoreProject.Steps;
using OpenQA.Selenium;

namespace CoreProject.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }

    protected NavigationSteps _navigationSteps;
    protected ProjectSteps _projectSteps;

    protected User Admin { get; private set; }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;

        _navigationSteps = new NavigationSteps(Driver);
        _projectSteps = new ProjectSteps(Driver);

        Admin = new User
        {
            Email = Configurator.AppSettings.Username,
            Password = Configurator.AppSettings.Password
        };
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}