using OpenQA.Selenium;

namespace SauceDemoHW.Pages;

public class CheckoutInfoPage : BasePage
{
    public CheckoutInfoPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        throw new NotImplementedException();
    }

    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }
}