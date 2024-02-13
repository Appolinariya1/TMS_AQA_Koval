using System.Text;
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
    protected AllureSteps AllureSteps;

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
        AllureSteps = new AllureSteps(Driver);
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
        {
            Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            byte[] screenshoteBytes = screenshot.AsByteArray;

            // IWebElement test = Driver.FindElement(By.Id("sss"));
            // Screenshot screenshotElement = ((ITakesScreenshot)test).GetScreenshot();

            //Прикрепление скриншота к отчету
            //Вариант 1
            AllureLifecycle.Instance.AddAttachment("Screenshot", "image/png", screenshoteBytes);

            //Вариант 2
            AllureApi.AddAttachment("Screenshot", "image/png", screenshoteBytes);
            AllureApi.AddAttachment("data.txt", "text/plain", Encoding.UTF8.GetBytes("This is the file content"));
        }

        Driver.Quit();
    }
}