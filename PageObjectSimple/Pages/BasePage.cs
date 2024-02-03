using OpenQA.Selenium;

namespace SeleniumBasic.Pages;

public class BasePage
{
    public BasePage(IWebDriver driver)
    {
        Driver = driver;
    }

    protected IWebDriver Driver { get; private set; }
}