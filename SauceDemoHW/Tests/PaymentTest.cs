using SauceDemoHW.Helpers.Configuration;
using SauceDemoHW.Pages;

namespace SauceDemoHW.Tests;

public class PaymentTest : BaseTest
{
    [Test]
    [Description("Тест на оплату")]
    public void CheckPaymentTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        ProductsPage productsPage =
            loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        productsPage.AddProduct();
        CartPage cartPage = productsPage.ClickShoppingCartLink();

        Assert.Multiple(() =>
        {
            Assert.That(cartPage.IsPageOpened());
            Assert.That(cartPage.ProductLabel.Text, Is.EqualTo("Sauce Labs Backpack"));
        });

        CheckoutInfoPage checkoutInfoPage = cartPage.ClickCheckoutButton();
        Assert.That(checkoutInfoPage.IsPageOpened);

        CheckoutOverviewPage checkoutOverviewPage = checkoutInfoPage.CheckInfo("Polina", "Ko", "123456");

        Assert.Multiple(() =>
        {
            Assert.That(checkoutOverviewPage.IsPageOpened());
            Assert.That(checkoutOverviewPage.ProductBackpack.Text, Is.EqualTo("Sauce Labs Backpack"));
            Assert.That(checkoutOverviewPage.SummaryTotalLabel.Text.Trim(), Is.EqualTo("Total: $32.39"));
            Assert.That(checkoutOverviewPage.FinishButtonVisible, Is.EqualTo(true));
        });

        CheckoutCompletePage checkoutCompletePage = checkoutOverviewPage.ClickFinishButton();
        Assert.Multiple(() =>
        {
            Assert.That(checkoutCompletePage.IsPageOpened());
            Assert.That(checkoutCompletePage.CompleteLabel.Text, Is.EqualTo("Thank you for your order!"));
        });
    }
}