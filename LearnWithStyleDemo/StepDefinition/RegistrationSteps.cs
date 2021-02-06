using LearnWithStyleDemo.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace LearnWithStyleDemo.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }









        

        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            registrationPage.NavigateToWebsite();

        }


        [Given(@"I click sign up button")]
        public void GivenIClickSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }

        
        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            registrationPage.EnterUsername();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            registrationPage.ClickOnSignUp();
        }
        
        [Then(@"I should be able to register")]
        public void ThenIShouldBeAbleToRegister()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsUserLoginDisplayed);
        }

        [Given(@"I enter my email")]
        public void GivenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }


        [Given(@"I click inside the text box")]
        public void GivenIClickInsideTheTextBox()
        {
            registrationPage.ClickOnTextBox();
        }

        [When(@"I select a language")]
        public void WhenISelectALanguage()
        {
            registrationPage.ClickOnLanguage();
        }

        [When(@"I slect the skill")]
        public void WhenISlectTheSkill()
        {
            registrationPage.SelectSkillFromDropDown();
        }







    }
}
