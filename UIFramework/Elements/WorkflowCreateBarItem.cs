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
            return null;
        }
         
        protected IWebElement NameTextbox;
        protected IWebElement SaveButton;

        public void SetName(string name)
        {
        }

        public string GetName()
        {
            return null;
        }

        public void Save()
        {            
        }
    }
}
