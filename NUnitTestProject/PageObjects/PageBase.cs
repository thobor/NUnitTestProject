using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTestProject.PageObjects
{
    public abstract class PageBase : Base
    {  
        public static WebDriverWait Wait;

        public string Title => Wait.Until(c => c.Title);

        public PageBase(IWebDriver driver)
        {
            _driver = driver;
            Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(int.Parse(settings["Timeout"])));
            WaitForPageLoad();
        }

        public void Press(IWebElement element)
        {
            Wait.Until(c => element.Enabled);

            new Actions(_driver).MoveToElement(element);

            element.Click();
        }

        protected void WaitForPageLoad()
        {
            Wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
