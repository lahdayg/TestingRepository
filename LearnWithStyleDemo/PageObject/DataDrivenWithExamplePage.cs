using LearnWithStyleDemo.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnWithStyleDemo.PageObject
{
    class DataDrivenWithExamplePage
    {
        public DataDrivenWithExamplePage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement signUp => driver.FindElement(By.CssSelector("body > div.ng-scope > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));

        IWebElement username => driver.FindElement(By.CssSelector("body > div.ng-scope > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));

        IWebElement email => driver.FindElement(By.XPath("//input[@type='email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@type='password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@type='submit']"));




        public void ClickOnSignUpButton()
        {
            signUp.Click();
        }

        public void EnterUsername(string Username)
        {
            //Random randomGenerator = new Random();
            //int randomInt = randomGenerator.Next(1000);
            //username.SendKeys("demo44" + randomInt);
            username.SendKeys(Username);
        }


        public void EnterEmail(string Email)
        {
            //Random randomGenerator = new Random();
            //int randomInt = randomGenerator.Next(1000);
            //email.SendKeys("learn" + randomInt + "@gmail.com");
            email.SendKeys(Email);
        }

        public void EnterPassword(string Password)
        {
            password.SendKeys(Password);
        }

        public void ClickOnSignUp()
        {
            signUpButton.Click();
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }














    }
}
