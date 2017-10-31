using OpenQA.Selenium;

namespace UIFramework.Elements
{
    public class BaseElement
    {
        private IWebElement mElement;

        public IWebElement Element => mElement;

        public BaseElement(IWebElement element)
        {
            mElement = element;
        }
    }
}
