using OpenQA.Selenium;

namespace UIFramework.Elements
{
    public class WorkflowEditBarItem : WorkflowCreateBarItem
    {
        public WorkflowEditBarItem(IWebElement element) 
            : base(element) { }

        public static new By BY()
        {
            return By.XPath("//li[contains(@class, 'bar-item__node')][.//div[@class='workflow-bar-item__pane--animation__expanded']]");
        }        
    }
}
