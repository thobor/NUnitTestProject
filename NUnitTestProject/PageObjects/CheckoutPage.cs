using OpenQA.Selenium;

namespace NUnitTestProject.PageObjects
{
    public class CheckoutPage : PageBase
    {
        public CheckoutPage(IWebDriver driver)
            : base(driver)
        {
            Wait.Until(c => c.FindElement(By.Id("CheckoutOrderPage")));        
        }
    }
}
