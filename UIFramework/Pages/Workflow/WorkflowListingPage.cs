using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UIFramework.Elements;

namespace UIFramework.Pages.Workflow
{
    // TODO 15a: Create WorkflowListingPage inheriting BasePage
    public class WorkflowListingPage : BasePage
    {
        public const string WORKFLOW_LISTING_URL = "https://app.kenticocloud.com/#/bc18abd1-f57a-49e9-b77d-667b9d4815b1/workflow";
        public WorkflowListingPage(IWebDriver driver) 
            : base(driver) { }

        // TODO 15d: Implement create new workflow button
        public IWebElement CreateNewButton => Driver.FindElement(By.XPath("//div[@class='bar-item__list-actions']//button"));

        // TODO 15b: Implement GoTo method to navigate to workflow listing
        // Method should wait until the page with workflow table is fully loaded
        public void GoTo()
        {
            Driver.Navigate().GoToUrl(WORKFLOW_LISTING_URL);
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementExists(WorkflowBarItem.BY()));
        }

        // TODO 15c: Implement a method that creates a new workflow 
        public void CreateWorkflow(string workflowName)
        {
            CreateNewButton.Click();
            var editElement = new WorkflowCreateBarItem(Driver.FindElement(WorkflowCreateBarItem.BY()));
            editElement.SetName(workflowName);
            editElement.Save();
        }

        // TODO 15e: Implement method that edits workflow with specified name
        // Return an instance of WorkflowEditBarItem
        public WorkflowEditBarItem EditWorkflow(string workflowName)
        {
            var item = new WorkflowBarItem(Driver.FindElement(WorkflowBarItem.BY(workflowName)));
            item.EditAction.Click();
            return new WorkflowEditBarItem(Driver.FindElement(WorkflowEditBarItem.BY()));
        }
    }
}
