using CoreProject.Core;
using CoreProject.Pages;
using NUnit.Framework;

namespace AdvancedSpecFlowProject.Steps;

[Binding]
public class LoginPageGuiStepDefs : BaseGuiSteps
{
    private readonly LoginPage _loginPage;

    public LoginPageGuiStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _loginPage = new LoginPage(Driver);
    }

    [When(@"user enter ""(.*)"" to the email field")]
    public void SetEmail(string value)
    {
        _loginPage.SetEmail(value);
    }

    [When(@"user enter ""(.*)"" to the password field")]
    public void SetPassword(string value)
    {
        _loginPage.SetPassword(value);
    }

    [When(@"user clicks the log in button")]
    public void ClickLogInButton()
    {
        _loginPage.LoginInButton.Click();
    }

    [Then(@"user is successfully logged in")]
    public void IsSuccessfullyLoggedIn()
    {
        Assert.That(new DashboardPage(Driver).SidebarProjectsAddButton.Displayed);
    }

    [Then(@"error ""(.*)"" is displayed")]
    public void IsErrorDisplayed(string value)
    {
        Assert.That(_loginPage.ErrorLabel.Text.Trim(),
            Is.EqualTo(value));
    }
}