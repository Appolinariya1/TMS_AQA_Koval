using OpenQA.Selenium;

namespace SauceDemoHW.Pages;

public class LoginPage : BasePage
{
    private static string END_POINT = "";

    // Описание элементов
    private static readonly By UsernameInputBy = By.Id("user-name");
    private static readonly By PswInputBy = By.Id("password");
    private static readonly By LoginInButtonBy = By.Id("login-button");
    private static readonly By ErrorLabelBy = By.XPath("//h3[@data-test='error']");

    public LoginPage(IWebDriver driver) : base(driver)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return LoginInButton.Displayed && UsernameInput.Displayed;
    }

    // Методы поиска элементов
    public IWebElement UsernameInput => WaitsHelper.WaitForExists(UsernameInputBy);
    public IWebElement ErrorLabel => WaitsHelper.WaitForExists(ErrorLabelBy);
    public IWebElement PswInput => WaitsHelper.WaitForExists(PswInputBy);
    public IWebElement LoginInButton => WaitsHelper.WaitForExists(LoginInButtonBy);

    //Комплексные методы
    public ProductsPage SuccessfulLogin(string username, string password)
    {
        UsernameInput.SendKeys(username);
        PswInput.SendKeys(password);
        LoginInButton.Click();

        return new ProductsPage(Driver, false);
    }

    public LoginPage IncorrectLogin(string username, string password)
    {
        UsernameInput.SendKeys(username);
        PswInput.SendKeys(password);
        LoginInButton.Click();

        return this;
    }
}