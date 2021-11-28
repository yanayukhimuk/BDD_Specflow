using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_Specflow.Pages
{
    public class LoginPage
    {
        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver)
        {
            if (webDriver is null)
            {
                throw new ArgumentNullException(nameof(webDriver));
            }
            else
                WebDriver = webDriver;
        }

        //UI elements
        public IWebElement EmailAddr => WebDriver.FindElement(By.XPath("//input[@class='email-input svelte-1tib0qz']"));
        public IWebElement PasswordNextButton => WebDriver.FindElement(By.XPath("//button[@class='button svelte-1tib0qz']"));
        public IWebElement PasswordInput => WebDriver.FindElement(By.XPath("//input[@class='password-input svelte-1tib0qz']"));
        public IWebElement EnterButton => WebDriver.FindElement(By.XPath("//button[@class='second-button svelte-1tib0qz']"));
        public IWebElement NewLetter => WebDriver.FindElement(By.XPath("//span[@class='compose-button__txt']"));

        public void EnterEmailAddr(string email)
        {
            EmailAddr.Click();
            EmailAddr.SendKeys(email);
            PasswordNextButton.Click();
        }

        public void EnterPassword(string pass)
        {
            PasswordInput.Click();
            PasswordInput.SendKeys(pass);
            EnterButton.Click();
        }

        public bool IsNewLetterDisplayed() => NewLetter.Displayed;
    }
}
