using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIFramework
{
    public class SeleniumTest
    {
        private string CHROME_BINARY_PATH = @"C:\Git\TestCrunch2017\Chromium\chrome.exe";

        // TODO 3b: Define a new property Driver of IWebDriver type
        public IWebDriver Driver
        {
            get;
            set;
        }
        
        public IWebDriver InitWebDriver()
        {
            var service = ChromeDriverService.CreateDefaultService();
            var options = new ChromeOptions()
            {
                // TODO 1: Create new ChromeOptions with path to the chrome binary
                BinaryLocation = CHROME_BINARY_PATH
            };

            return new ChromeDriver(service, options);
        }        

        [SetUp]
        public void SetUp()
        {
            // TODO 3a: Create a chrome driver instance before every test with NUnit life cycle
            // Decorate the method with [SetUp] attribute
            // Define a new property Driver of IWebDriver type
            // Init Driver property with InitWebDriver() method
            Driver = InitWebDriver();

            // TODO 8: Set implicit wait for element
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [TearDown]
        public void TearDown()
        {
            // TODO 4: Dispose the web driver instance after every test with NUnit life cycle
            // Decorate the method with [TearDown] attribute
            // Dispose the web driver
            Driver.Dispose();
        }
    }
}
