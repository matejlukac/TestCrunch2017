using OpenQA.Selenium;

namespace UIFramework.Pages
{
    public class BasePage
    {
        private IWebDriver mDriver;

        public IWebDriver Driver => mDriver;

        public BasePage(IWebDriver driver)
        {
            mDriver = driver;
        }
    }
}
