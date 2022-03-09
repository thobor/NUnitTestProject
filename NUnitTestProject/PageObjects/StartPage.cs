using OpenQA.Selenium;

namespace NUnitTestProject.PageObjects
{
    public class StartPage : PageBase
    {
        private IWebElement AcceptCookiesButton => Wait.Until(c => c.FindElement(By.XPath("//*[@data-test='accept-cookies-button']")));
        private IWebElement HandlaDropdown => Wait.Until(c => c.FindElement(By.XPath("//*[@data-test='Handla']")));
        private IWebElement HandlaMobiltelefonerLink => Wait.Until(c => c.FindElement(By.XPath("//*[@data-test='Mobiltelefoner']")));

        public StartPage(IWebDriver driver)
            : base(driver)
        {                        
            GoToStartPage();
        }

        public void GoToStartPage()
        {
            _driver.Navigate().GoToUrl("https://www.telenor.se/");

        }
         
        public PurchasePage GoToPurchasePhonesPage()
        {            
            Press(HandlaDropdown);
            Press(HandlaMobiltelefonerLink);

            return new PurchasePage(_driver);
        }

        public void AcceptCookies()
        {
            Wait.Until(c => AcceptCookiesButton.Enabled);
            Press(AcceptCookiesButton);
        }
    }
}
