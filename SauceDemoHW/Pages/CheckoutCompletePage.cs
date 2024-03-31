using OpenQA.Selenium;

namespace SauceDemoHW.Pages;

public class CheckoutCompletePage : BasePage
{
    private static string END_POINT = "checkout-complete.html";
    private static readonly By TitleLabelBy = By.ClassName("title");
    private static readonly By CompleteLabelBy = By.ClassName("complete-header");
    private static readonly By BackHomeButtonBy = By.Id("back-to-products");

    public CheckoutCompletePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleLabel.Text.Trim().Equals("Checkout: Complete!");
    }

    public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
    public IWebElement CompleteLabel => WaitsHelper.WaitForExists(CompleteLabelBy);
    public IWebElement BackHomeButton => WaitsHelper.WaitForExists(BackHomeButtonBy);

    public ProductsPage ClickBackHomeButton()
    {
        BackHomeButton.Click();
        return new ProductsPage(Driver, true);
    }
}