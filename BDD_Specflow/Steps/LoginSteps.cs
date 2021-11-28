using BDD_Specflow.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD_Specflow.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        LoginPage loginPage = null;
        IWebDriver webDriver = new ChromeDriver();

        // Step definitions
        [Given(@"I enter email")]
        public void GivenIEnterEmail(Table table)
        {
            loginPage = new LoginPage(webDriver);
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterEmailAddr((string)data.EmailAddress);
        }

        [Given(@"I  enter password")]
        public void GivenIEnterPassword(Table table)
        {
            loginPage = new LoginPage(webDriver);
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterEmailAddr((string)data.Password);
        }

        [Then(@"I should see the New Letter button")]
        public void ThenIShouldSeeTheNewLetterButton()
        {
            loginPage = new LoginPage(webDriver);
            Assert.That(loginPage.IsNewLetterDisplayed());
        }

    }
}
