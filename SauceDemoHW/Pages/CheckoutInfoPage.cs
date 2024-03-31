using OpenQA.Selenium;

namespace SauceDemoHW.Pages;

public class CheckoutInfoPage : BasePage
{
    private static string END_POINT = "checkout-step-one.html";
    private static readonly By TitleLabelBy = By.ClassName("title");
    private static readonly By FirstNameInputBy = By.Id("first-name");
    private static readonly By LastNameInputBy = By.Id("last-name");
    private static readonly By PostalCodeInputBy = By.Id("postal-code");
    private static readonly By ContinueButtonBy = By.Id("continue");
    private static readonly By CancelButtonBy = By.Id("cancel");
    
    public CheckoutInfoPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleLabel.Text.Trim().Equals("Checkout: Your Information");
    }
    
    public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
    public IWebElement FirstNameInput => WaitsHelper.WaitForExists(FirstNameInputBy);
    public IWebElement LastNameInput => WaitsHelper.WaitForExists(LastNameInputBy);
    public IWebElement PostalCodeInput => WaitsHelper.WaitForExists(PostalCodeInputBy);
    public IWebElement ContinueButton => WaitsHelper.WaitForExists(ContinueButtonBy);
    public IWebElement CancelButton => WaitsHelper.WaitForExists(CancelButtonBy);

    public CheckoutOverviewPage CheckInfo(string firstName, string lastName, string postalCode)
    {
        FirstNameInput.SendKeys(firstName);
        LastNameInput.SendKeys(lastName);
        PostalCodeInput.SendKeys(postalCode);
        ContinueButton.Click();
        return new CheckoutOverviewPage(Driver, true);
    }
}