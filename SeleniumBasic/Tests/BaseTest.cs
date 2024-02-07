using NUnitTest.Core;
using OpenQA.Selenium;

namespace SeleniumBasic.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)] //чтобы инициализация базового класса была для каждого кейса
public class BaseTest
{
    protected IWebDriver Driver { get; set; }

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}