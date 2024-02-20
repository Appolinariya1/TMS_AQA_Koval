using ChainOfInvocations.Pages;
using OpenQA.Selenium;

namespace ChainOfInvocations.Steps;

public class UserSteps : BaseSteps
{
    private LoginPage _loginPage;
    
    public UserSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }

    
}