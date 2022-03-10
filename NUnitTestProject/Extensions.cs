using OpenQA.Selenium;
using System.Collections.Generic;

namespace NUnitTestProject
{
    public static class Extensions
    {   
        public static IWebElement FindElementByDataTestId(this ISearchContext searchContext, string text)
        {            
            var locator = By.XPath($"//*[@data-test='{text}']");

            return searchContext.FindElement(locator);
        }

        public static IEnumerable<IWebElement> FindElementsByDataTestId(this ISearchContext searchContext, string text)
        {
            var locator = By.XPath($"//*[@data-test='{text}']");

            return searchContext.FindElements(locator);
        }
    }
}
