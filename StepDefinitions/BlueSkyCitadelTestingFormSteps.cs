using BlueSkyCitadelProject.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadelProject.StepDefinitions
{
    [Binding]
    public class BlueSkyCitadelTestingFormSteps
    {
        AutomationTestingFormPage automationTestingFormPage;
    
        public BlueSkyCitadelTestingFormSteps()
        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }
        [Given(@"I navigate to the BlueSky Testing Form")]
        public void GivenINavigateToTheBlueSkyTestingForm()
        {
            automationTestingFormPage.NavigateToForm();
        }
        
        [When(@"I enter the Single Line Text")]
        public void WhenIEnterTheSingleLineText()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the one in the select Box")]
        public void WhenIEnterTheOneInTheSelectBox()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I select the Multi-Select")]
        public void WhenISelectTheMulti_Select()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I select the Radio List")]
        public void WhenISelectTheRadioList()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I select the Check Box List")]
        public void WhenISelectTheCheckBoxList()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I select United Kingdom as Country")]
        public void WhenISelectUnitedKingdomAsCountry()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I select (.*)th of the current month")]
        public void WhenISelectThOfTheCurrentMonth(int message)
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Paragraph Text")]
        public void WhenIEnterParagraphText()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"message ""(.*)""")]
        public void ThenMessage(string message)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
