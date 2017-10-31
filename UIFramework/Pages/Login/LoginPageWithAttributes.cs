using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UIFramework
{
    public class LoginPageWithAttributes
    {
        // TODO 10: Find elements on the login page using FindsBy attribute
        // [FindsBy(How = How.Id, Using = "login_username")]
        private IWebElement EmailTextbox;        
        private IWebElement PasswordTextbox;        
        private IWebElement SubmitButton;

        public void SignIn(string username, string password)
        {
            EmailTextbox.SendKeys(username);
            PasswordTextbox.SendKeys(password);
            SubmitButton.Submit();
        }
    }
}
