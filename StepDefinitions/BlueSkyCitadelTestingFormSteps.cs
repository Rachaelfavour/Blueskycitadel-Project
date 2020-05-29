using BlueSkyCitadelProject4.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadelProject4.StepDefinitions
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
            automationTestingFormPage.EnterSingleLineText();
        }
        
        [When(@"I enter the one in the select Box")]
        public void WhenIEnterTheOneInTheSelectBox()
        {
            automationTestingFormPage.SelectOneFromSelectOneTwoThree();
        }
        
        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
            automationTestingFormPage.EnterEmail();
        }
        
        [When(@"I select the Multi-Select")]
        public void WhenISelectTheMulti_Select()
        {
            automationTestingFormPage.SelectMultiSelector();
        }
        
        [When(@"I select the Radio List")]
        public void WhenISelectTheRadioList()
        {
            automationTestingFormPage.ClickRadioList();
        }
        
        [When(@"I select the Check Box List")]
        public void WhenISelectTheCheckBoxList()
        {
          //  ScenarioContext.Current.Pending();
        }
        
        [When(@"I select United Kingdom as Country")]
        public void WhenISelectUnitedKingdomAsCountry()
        {
            automationTestingFormPage.SelectUnitedKingdomFromCountry();
        }
        
        [When(@"I select (.*)th of the current month")]
        public void WhenISelectThOfTheCurrentMonth(int message)
        {
            automationTestingFormPage.EnterDateFromCalendar();
        }
        
        [When(@"I enter Paragraph Text")]
        public void WhenIEnterParagraphText()
        {
            automationTestingFormPage.EnterParagraphText();
        }
        
        [When(@"I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"message ""(.*)""")]
        public void ThenMessage(string message)
        {
          //  ScenarioContext.Current.Pending();
        }
    }
}
