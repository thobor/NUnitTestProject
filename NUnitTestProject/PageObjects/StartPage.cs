using OpenQA.Selenium;

namespace NUnitTestProject.PageObjects
{
    public class StartPage : PageBase
    {
        private IWebElement AcceptCookiesButton => Wait.Until(c => c.FindElementByDataTestId("accept-cookies-button"));
        private IWebElement HandlaDropdown => Wait.Until(c => c.FindElementByDataTestId("Handla"));
        private IWebElement HandlaMobiltelefonerLink => Wait.Until(c => c.FindElementByDataTestId("Mobiltelefoner"));

        public StartPage(IWebDriver driver)
            : base(driver)
        {
            GoToStartPage();
        }

        public void GoToStartPage()
        {
            _driver.Navigate().GoToUrl("https://www.telenor.se/");
            Wait.Until(c => c.FindElement(By.Id("main")));
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
