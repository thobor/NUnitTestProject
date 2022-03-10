using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NUnitTestProject.PageObjects
{
    public class PhoneDetailsPage : PageBase
    {
        public PhoneDetailsPage(IWebDriver driver)
            : base(driver)
        {
            Wait.Until(c => Subscriptions.Count() > 0); 
        }
        
        private IWebElement SubscriptionBlock => Wait.Until(c => c.FindElement(By.ClassName("subscription-picker")));
        private IEnumerable<IWebElement> Subscriptions => Wait.Until(c => SubscriptionBlock.FindElementsByDataTestId("subscription-picker-item"));
        private IEnumerable<IWebElement> NewNumbersButtons => Wait.Until(c => c.FindElements(By.XPath("//*[@value='newNumber']")));
        private IEnumerable<IWebElement> KeepNumbersButtonss => Wait.Until(c => c.FindElements(By.XPath("//*[@value='keepNumber']")));
        private IWebElement CartPanel => Wait.Until(c => c.FindElementByDataTestId("cart-panel"));
        private IWebElement ExtraUsers => Wait.Until(c => c.FindElementByDataTestId("ExtraSim"));
        private IWebElement ContinueButton => Wait.Until(c => CartPanel.FindElement(By.TagName("button")));

        public void SelectSubscriptions(int subscription)
        {
            Wait.Until(c => Subscriptions.Count() > 0);

            Press(Subscriptions.ElementAt(subscription));
        }

        public void SelectNumberOfUsers(int users)
        {
            Wait.Until(c => Subscriptions.Count() > 0);
            Press(Subscriptions.ElementAt(users + 6));
        }

        public void SelectNewNumbers()
        {
            Wait.Until(c => NewNumbersButtons.Count() > 0);

            foreach (var button in NewNumbersButtons.ToList())
            {
                Wait.Until(c => button.Enabled);
                Press(button);
                Thread.Sleep(3000);
            }
        }

        public CheckoutPage Continue()
        {
            Wait.Until(c => ContinueButton.Enabled);
            Press(ContinueButton);

            return new CheckoutPage(_driver);
        }
    }
}
