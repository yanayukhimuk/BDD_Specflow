using BDD_Specflow.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDD_Specflow.Steps
{
    [Binding]
    class HomeSteps
    {
        [Given(@"I launch the website")]
        public void GivenILaunchTheWebsite()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://mail.ru/");
        }
    }
}
