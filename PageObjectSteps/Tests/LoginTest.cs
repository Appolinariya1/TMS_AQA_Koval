using NUnitTest.Pages;
using SeleniumBasic.Helpers.Configuration;
using SeleniumBasic.Pages;
using SeleniumBasic.Steps;

namespace SeleniumBasic.Tests;

public class LoginTest : BaseTest
{
    [Test]
    
    public void SuccessfulLoginTest()
    {
        UserSteps userSteps = new UserSteps(Driver);
        DashboardPage dashboardPage =
            userSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
       Assert.That(dashboardPage.IsPageOpened);
    }
    
    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Проверка
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("ssdd", "")
                .ErrorLabel.Text.Trim(), 
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
    
    [Test]
    public void SuccessfulLoginStepsTest()
    {
        // Actions = Действия
        
        
        // Проверка
        Assert.That(
            UserSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .TitleLabel.Text.Trim(), 
            Is.EqualTo("All Projects"));
    }
}