using OpenQA.Selenium;
using UIFramework.Pages;

namespace UIFramework
{
    public class LoginPage : BasePage
    {
        public const string LOGIN_URL = "https://app.kenticocloud.com/sign-in";        

        // TODO 6a: Implement element properties on the login page
        private IWebElement EmailTextbox;
        private IWebElement PasswordTextbox;
        private IWebElement SubmitButton;

        public LoginPage(IWebDriver driver) 
            : base(driver) { }

        public void GoTo()
        {
            // TODO 6b: Navigate to login page URL
        }

        public void SignIn(string username, string password)
        {
            // TODO 6c: Fill in the form and submit
        }
    }
}
