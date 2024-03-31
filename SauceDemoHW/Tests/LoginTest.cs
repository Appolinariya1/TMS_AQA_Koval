using SauceDemoHW.Helpers.Configuration;
using SauceDemoHW.Pages;

namespace SauceDemoHW.Tests;

public class LoginTest : BaseTest
{
    [Test]
    [Description("Тест успешного входа в систему")]
    public void SuccessfulLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        ProductsPage productsPage = new ProductsPage(Driver, false);

        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    [Description("Тест неуспешного входа в систему")]
    public void InvalidUsernameLoginTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("ssdd", "")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Password is required"));
    }

    [Test]
    [Description("Тест входа заблокированного пользователя")]
    public void LockedUsernameLoginTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("locked_out_user", Configurator.AppSettings.Password)
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }
}