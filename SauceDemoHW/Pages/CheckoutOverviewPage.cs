using OpenQA.Selenium;

namespace SauceDemoHW.Pages;

public class CheckoutOverviewPage : BasePage
{
    private static string END_POINT = "checkout-step-two.html";
    private static readonly By TitleLabelBy = By.ClassName("title");
    private static readonly By ProductBackpackBy = By.ClassName("inventory_item_name");
    private static readonly By SummaryTotalLabelBy = By.ClassName("summary_total_label");
    private static readonly By FinishButtonBy = By.Id("finish");

    public CheckoutOverviewPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleLabel.Text.Trim().Equals("Checkout: Overview");
    }

    public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
    public IWebElement ProductBackpack => WaitsHelper.WaitForExists(ProductBackpackBy);
    public IWebElement SummaryTotalLabel => WaitsHelper.WaitForExists(SummaryTotalLabelBy);
    public IWebElement FinishButton => WaitsHelper.WaitForExists(FinishButtonBy);
    public bool FinishButtonVisible => WaitsHelper.WaitForVisibility(FinishButton);
    

    public CheckoutCompletePage ClickFinishButton()
    {
        FinishButton.Click();
        return new CheckoutCompletePage(Driver, true);
    }
}