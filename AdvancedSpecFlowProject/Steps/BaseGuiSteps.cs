using CoreProject.Core;
using OpenQA.Selenium;

namespace AdvancedSpecFlowProject.Steps;

[Binding]
public class BaseGuiSteps
{
    protected IWebDriver Driver { get; }
    protected ScenarioContext ScenarioContext { get; }

    public BaseGuiSteps(Browser browser, ScenarioContext scenarioContext)
    {
        Driver = browser.Driver;
        ScenarioContext = scenarioContext;
    }
}