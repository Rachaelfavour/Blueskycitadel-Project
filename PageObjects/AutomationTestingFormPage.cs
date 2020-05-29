using BlueSkyCitadelProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyCitadelProject.PageObjects
{
    class AutomationTestingFormPage
    { 
        IWebDriver driver;
        IWebElement singleLineText => driver.FindElement(By.Id("nf - field - 135"));
        public void EnterSingleLineText()
        {
            singleLineText.SendKeys("Rachael");
        }
    public AutomationTestingFormPage()
    {
            driver = Hook.driver;
    }
     public void NavigateToForm()
        {
            driver.Navigate().GoToUrl("https://blueskycitadel.com/automation-testing-form/");
        }
    }
}
