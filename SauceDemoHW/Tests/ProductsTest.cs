using SauceDemoHW.Helpers.Configuration;
using SauceDemoHW.Pages;

namespace SauceDemoHW.Tests;

public class ProductsTest : BaseTest
{
    [Test]
    [Description("Тест на добавление товара в корзину")]
    public void AddToCartTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        ProductsPage productsPage =
            loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        productsPage.AddProduct();

        Assert.Multiple(() =>
        {
            Assert.That(productsPage.ShoppingCartBadge.Text, Is.EqualTo("1"));
            Assert.That(productsPage.RemoveBackpackButton.Displayed);
        });

        CartPage cartPage = productsPage.ClickShoppingCartLink();

        Assert.Multiple(() =>
        {
            Assert.That(cartPage.IsPageOpened);
            Assert.That(cartPage.ProductLabel.Text, Is.EqualTo("Sauce Labs Backpack"));
        });
    }
}