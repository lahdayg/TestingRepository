using LearnWithStyleDemo.PageObject;
using System;
using TechTalk.SpecFlow;

namespace LearnWithStyleDemo.StepDefinition
{
    [Binding]
    public class DataDrivenWithExampleSteps
    {
        DataDrivenWithExamplePage dataDrivenWithExamplePage;

        public DataDrivenWithExampleSteps()
        {
            dataDrivenWithExamplePage = new DataDrivenWithExamplePage();
        }





        [Given(@"I enter my username ""(.*)""")]
        public void GivenIEnterMyUsername(string Username)
        {
            dataDrivenWithExamplePage.EnterUsername(Username);


        }
        
        [Given(@"I enter my emailaddress ""(.*)""")]
        public void GivenIEnterMyEmailaddress(string Email)
        {
            dataDrivenWithExamplePage.EnterEmail(Email);
        }
        
        [Given(@"I enter my passwordtext ""(.*)""")]
        public void GivenIEnterMyPasswordtext(string Password)
        {
            dataDrivenWithExamplePage.EnterPassword(Password);
        }
    }
}
