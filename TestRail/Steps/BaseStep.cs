using OpenQA.Selenium;
using TestRailComplexApi.Pages;
using TestRailComplexApi.Pages.ProjectPages;

namespace TestRailComplexApi.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}