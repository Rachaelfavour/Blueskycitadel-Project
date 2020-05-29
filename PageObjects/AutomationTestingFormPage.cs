using BlueSkyCitadelProject4.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyCitadelProject4.PageObjects
{
    class AutomationTestingFormPage
    {    IWebDriver driver;
        IWebElement singleLineText => driver.FindElement(By.CssSelector("#nf-field-135"));
        IWebElement selectOneTwoThree => driver.FindElement(By.Id("nf-field-136"));
        IWebElement multiSelect123 => driver.FindElement(By.Name("nf-field-137"));
        IWebElement email => driver.FindElement(By.Name("email"));
        IWebElement radioList => driver.FindElement(By.Id("nf-label-class-field-138-1"));
        IWebElement country => driver.FindElement(By.Id("nf-field-140"));
        IWebElement dateFromCalendar => driver.FindElement(By.CssSelector("input.pikaday__display.pikaday__display--pikaday.ninja-forms-field.nf-element.datepicker"));
        IWebElement paragraphText => driver.FindElement(By.CssSelector("#nf-field-143"));
        public void EnterParagraphText()
        {
            paragraphText.SendKeys("Rachael is a beautiful lady");
        }
        public void EnterDateFromCalendar()
        {
            dateFromCalendar.SendKeys("17/02/2020");
        }
        public void SelectUnitedKingdomFromCountry()
        {
            SelectElement select = new SelectElement(country);
            select.SelectByValue("GB");
        }
        public void ClickRadioList()
        {

            radioList.Click();
        }
        public void EnterEmail()

        {
            email.SendKeys("richkome@yahoo.com");
        }
        public void SelectMultiSelector()
        {
            SelectElement select = new SelectElement(multiSelect123);
            select.SelectByValue("two");
            select.SelectByValue("three");

            }
           public void SelectOneFromSelectOneTwoThree()
        {
            SelectElement select = new SelectElement(selectOneTwoThree);
            select.SelectByValue("one");
        }
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
