using System;
using System.Collections.Generic;
using System.Text;
using LearnWithStyleDemo.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LearnWithStyleDemo.PageObject
{
    class RegistrationPage
    {

        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement signUp => driver.FindElement(By.CssSelector("body > div.ng-scope > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));

        IWebElement username => driver.FindElement(By.CssSelector("body > div.ng-scope > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));

        IWebElement email => driver.FindElement(By.XPath("//input[@type='email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@type='password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        IWebElement userLogin => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(3) > li:nth-child(2) > a"));

        IWebElement textBox => driver.FindElement(By.XPath("//*[@id='msdd']"));

        IWebElement language => driver.FindElement(By.XPath("//a[text()='Arabic']"));

        IWebElement catalan => driver.FindElement(By.XPath("//a[text()='Catalan']"));

        IWebElement skill => driver.FindElement(By.XPath("//*[@id='Skills']"));




        public void ClickOnSignUpButton()
        {
            signUp.Click();
        }

        public void EnterUsername()
        {
            username.SendKeys("Akin4443");
        }


        public void EnterEmail()
        {
            email.SendKeys("demo+44433@example.com");
        }

        public void EnterPassword()
        {
            password.SendKeys("PasswordSecure");
        }

        public void ClickOnSignUp()
        {
            signUpButton.Click();
        }


        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public bool IsUserLoginDisplayed()
        {
            return userLogin.Displayed;
        }

        public void ClickOnTextBox()
        {
            textBox.Click();
        }

        public void ClickOnLanguage()
        {
            language.Click();
            catalan.Click();
        }

        public void SelectSkillFromDropDown()
        {
            SelectElement select = new SelectElement(skill);
            select.SelectByValue("Adobe Photoshop");
        }

    }
}
