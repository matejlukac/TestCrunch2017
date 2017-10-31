using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using UIFramework;
using UIFramework.Pages.Workflow;

namespace UITests.Tests
{
    public class SampleTest : SeleniumTest
    {        
        public void A_DriverExample()
        {
            // TODO 2: Create a simple test
            // Decorate method with [Test] attribute
            // Create an instance of WebDriver
            // Go to the url of your choice using IWebDriver.Navigate()
            // Dispose the driver            
        }
        
        [Test]
        public void B_LoginTestExample()
        {
            // TODO 5: Create login test
            // Navigate to login page https://app.kenticocloud.com/sign-in
            // Find username textbox by id and set the value
            // Find password textbox by id and set the value
            // Find login button and submit
        }


        [Test]
        public void C_LoginTestExampleWithPODP()
        {
            // TODO 7: Refactor login test - use page object design pattern
            // Create a new instance of LoginPage
            // Navigate to login page
            // Sign in
        }


        [Test]
        public void D_FindingElementsExample()
        {
            // TODO 9: Looking for elements  
            // Fill in missing identifiers
            var driver = InitWebDriver();

            driver.Navigate().GoToUrl(LoginPage.LOGIN_URL);
            driver.FindElement(By.Name("")).SendKeys("TestCrunch2017@gmail.com");
            driver.FindElement(By.XPath("")).SendKeys("TestCrunch2017");
            driver.FindElement(By.TagName("")).Click();

            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void E_SupportPageObjectsExample()
        {
            // TODO 11: Initialize page elements with PageFactory
            // Create a new instance of LoginPageWithAttributes
            // Navigate to Login page
            // Initialize elements in the page with PageFactory.InitElements
            // Sign in            
        }

        [Test]
        public void F_DriverWaitExample()
        {
            // TODO 13: Waiting
            // Sign in
            // Wait for the Content inventory page to load
            // The page is fully loaded when the table with data is displayed

            

            // TODO 14: Refactor waiting using ExpectedConditions
        }

        [Test]
        public void G_CreateNewWorkflow()
        {
            // TODO 18: Workflow test
            // Create a new workflow
            // Edit the created workflow         
        }
    }
}
