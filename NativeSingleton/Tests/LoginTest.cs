using NativeSingleton.Core;
using NativeSingleton.Pages;
using OpenQA.Selenium;

namespace NativeSingleton.Tests;

[TestFixture]
public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
       Assert.That(new DashboardPage().SidebarProjectsAddButton.Displayed);
    }
}