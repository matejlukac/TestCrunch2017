using OpenQA.Selenium;

namespace UIFramework.Elements
{
    // TODO 17: Implement methods and properties of WorkflowCreateBarItem
    public class WorkflowCreateBarItem : BaseElement
    {
        public WorkflowCreateBarItem(IWebElement element) 
            : base(element) { }

        public static By BY()
        {
            return By.XPath("//li[@class='bar-item__node--create-new']");
        }
         
        protected IWebElement NameTextbox => Element.FindElement(By.Name("name"));
        protected IWebElement SaveButton => Element.FindElement(By.XPath(".//button[@type='submit']"));

        public void SetName(string name)
        {
            NameTextbox.SendKeys(name);
        }

        public string GetName()
        {
            return NameTextbox.GetAttribute("value");
        }

        public void Save()
        {
            SaveButton.Click();
        }
    }
}
