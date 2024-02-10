using NUnitTest.Pages;
using OpenQA.Selenium;
using SeleniumBasic.Pages;

namespace SeleniumBasic.Steps;

public class UserSteps : BaseSteps
{
    private LoginPage _loginPage;
    
    public UserSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }

    // Комплексные
    public DashboardPage SuccessFulLogin(string username, string password)
    {
        _loginPage.EmailInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.LoginInButton.Click();

        return new DashboardPage(Driver);
    }

    public LoginPage IncorrectLogin(string username, string password)
    {
        _loginPage.EmailInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.LoginInButton.Click();

        return this;
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return _loginPage.LoginInButton.Displayed && _loginPage.EmailInput.Displayed;
    }
    public DashboardPage SuccessfulLogin(string username, string password)
    {
        _loginPage.EmailInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.LoginInButton.Click();

        return new DashboardPage(Driver);
    }
}