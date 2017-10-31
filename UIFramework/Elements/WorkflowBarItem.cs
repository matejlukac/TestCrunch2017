using OpenQA.Selenium;

namespace UIFramework.Elements
{
    public class WorkflowBarItem : BaseElement
    {
        public WorkflowBarItem(IWebElement element) 
            : base(element) { }

        public static By BY(string workflowName = "")
        {
            return By.XPath($"//li[@class='bar-item__node'][.//*[contains(text(),'{workflowName}')]]");
        }

        // TODO 16: Implement edit workflow bar action
        public IWebElement EditAction;
    }
}
