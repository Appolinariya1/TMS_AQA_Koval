using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace Allure.Steps;

public class AllureSteps : BaseSteps
{
    public AllureSteps(IWebDriver driver) : base(driver)
    {
    }

    [AllureStep("Test {url")]
    public void TestDomain(string url)
    {
        // Добавление дополнительной информации
        AllureLifecycle.Instance.UpdateStep(stepResult =>
            stepResult.parameters.Add(
                new Parameter
                {
                    name = "Started at", value = DateTime.Now.ToString()
                }));
        OpenBrowser();
        GoToWebSite(url);
        CloseBrowser();
    }

    [AllureStep("Open web browser")]
    public void OpenBrowser()
    {
        Assert.That(true);
    }

    [AllureStep("Visit {url}")]
    public void GoToWebSite([Skip] string url)
    {
        Assert.That(true);
    }

    [AllureStep("Close web browser")]
    public void CloseBrowser()
    {
        Assert.That(true);
    }
}