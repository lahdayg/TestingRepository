using LearnWithStyleDemo.PageObject;
using System;
using TechTalk.SpecFlow;

namespace LearnWithStyleDemo.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {

        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }







        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }

        
        [Given(@"I click sign up")]
        public void GivenIClickSignUp()
        {
            dataDrivenWithParameterPage.ClickOnSignUpButton();
        }
        
        [Given(@"I enter my Username ""(.*)""")]
        public void GivenIEnterMyUsername(string Username)
        {
            dataDrivenWithParameterPage.EnterUsername(Username);
        }
        
        [Given(@"I enter my email ""(.*)""")]
        public void GivenIEnterMyEmail(string Email)
        {
            dataDrivenWithParameterPage.EnterEmail(Email);
        }
        
        [Given(@"I enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string Password)
        {
            dataDrivenWithParameterPage.EnterPassword(Password);
        }
        
        [When(@"I click on sign button")]
        public void WhenIClickOnSignButton()
        {
            dataDrivenWithParameterPage.ClickOnSignUp();
        }
    }
}
