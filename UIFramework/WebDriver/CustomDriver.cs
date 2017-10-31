using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace UIFramework
{
    public class CustomDriver
    {
        public IWebDriver InternalDriver
        {
            get;
            internal set;
        }

        public TimeSpan ImplicitWait
        {
            get
            {
                return InternalDriver.Manage().Timeouts().ImplicitWait;
            }
            set
            {
                InternalDriver.Manage().Timeouts().ImplicitWait = value;
            }
        }

        public CustomDriver(IWebDriver driver)
        {
            InternalDriver = driver;
        }

        /// <summary>
        /// Finds elements by the element selector specified in the parameters.
        /// Polls to find at least one element until implicit timeout when wait is set to true, 
        /// or immediately returns all elements on the page when wait is set to false.
        /// </summary>
        /// <param name="by">Element selector.</param>
        /// <param name="wait"> Wait for at least one element to be found.</param>
        public List<IWebElement> CustomFindElements(By by, bool wait)
        {
            var timeout = ImplicitWait;
            if (!wait)
            {
                // TODO 12a: Set Implicit timeout to zero
            }

            try
            {
                // TODO 12b: Return all elements found by element selector
                return null;
            }
            finally
            {
                ImplicitWait = timeout;
            }           
        }
    }
}
