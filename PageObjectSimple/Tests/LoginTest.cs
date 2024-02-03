using SeleniumBasic.Helpers.Configuration;
using SeleniumBasic.Pages;

namespace SeleniumBasic.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        var loginPage = new LoginPage(Driver);
        loginPage.EmailInput.SendKeys(Configurator.AppSettings.Username);
    }
}