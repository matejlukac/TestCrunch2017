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
        [Test]
        public void A_DriverExample()
        {
            // TODO 2: Create a simple test
            // Decorate method with [Test] attribute
            // Create an instance of WebDriver
            // Go to the url of your choice using IWebDriver.Navigate()
            // Dispose the driver

            var driver = InitWebDriver();
            driver.Navigate().GoToUrl("http://localhost");
            driver.Quit();
            driver.Dispose();
        }
        
        [Test]
        public void B_LoginTestExample()
        {
            // TODO 5: Create login test
            // Navigate to login page https://app.kenticocloud.com/sign-in
            // Find username textbox by id and set the value
            // Find password textbox by id and set the value
            // Find login button and submit
            
            Driver.Navigate().GoToUrl(LoginPage.LOGIN_URL);
            Driver.FindElement(By.Id("login_username")).SendKeys("TestCrunch2017@gmail.com");
            Driver.FindElement(By.Id("login_password")).SendKeys("TestCrunch2017");
            Driver.FindElement(By.Id("btn-login")).Click();
        }


        [Test]
        public void C_LoginTestExampleWithPODP()
        {
            // TODO 7: Refactor login test - use page object design pattern
            // Create a new instance of LoginPage
            // Navigate to login page
            // Sign in
            var page = new LoginPage(Driver);
            page.GoTo();
            page.SignIn("TestCrunch2017@gmail.com", "TestCrunch2017");
        }


        [Test]
        public void D_FindingElementsExample()
        {
            // TODO 9: Looking for elements  
            // Fill in missing identifiers           
            Driver.Navigate().GoToUrl(LoginPage.LOGIN_URL);
            Driver.FindElement(By.Name("login[username]")).SendKeys("TestCrunch2017@gmail.com");
            Driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("TestCrunch2017");
            Driver.FindElement(By.TagName("button")).Click();
        }

        [Test]
        public void E_SupportPageObjectsExample()
        {
            // TODO 11: Initialize page elements with PageFactory
            // Create a new instance of LoginPageWithAttributes
            // Navigate to Login page
            // Initialize elements in the page with PageFactory.InitElements
            // Sign in            
            var page = new LoginPageWithAttributes();
            Driver.Navigate().GoToUrl(LoginPage.LOGIN_URL);
            PageFactory.InitElements(Driver, page);
            page.SignIn("TestCrunch2017@gmail.com", "TestCrunch2017");
        }

        [Test]
        public void F_DriverWaitExample()
        {
            var page = new LoginPage(Driver);
            page.GoTo();
            page.SignIn("TestCrunch2017@gmail.com", "TestCrunch2017");

            // TODO 13: Waiting
            // Sign in
            // Wait for the Content inventory page to load
            // The page is fully loaded when the table with data is displayed

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.IgnoreExceptionTypes(new Type[] { typeof(StaleElementReferenceException) });
            
            wait.Until(d =>
            {
                return d.FindElements(By.TagName("table")).Count > 0;
            });

            // TODO 14: Refactor waiting using ExpectedConditions
            wait.Until(ExpectedConditions.ElementExists(By.TagName("table")));
        }

        [Test]
        public void G_CreateNewWorkflow()
        {
            // TODO 18a: Workflow test
            // Create a new workflow
            // Edit the created workflow

            var page = new LoginPage(Driver);
            page.GoTo();
            page.SignIn("TestCrunch2017@gmail.com", "TestCrunch2017");

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementExists(By.TagName("table")));

            var listing = new WorkflowListingPage(Driver);
            listing.GoTo();
            listing.CreateWorkflow("test");
            var editWorkflowElement = listing.EditWorkflow("test");

            // TODO 18b: Use assert in test
            Assert.That(editWorkflowElement.GetName, Is.EqualTo("test"));

            // TODO 19b: Create a screenshot in test
            TakeScreenShot($"C:\\Logs\\{Guid.NewGuid().ToString()}mytest1.png");
        }
    }
}
