using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject.PageObjects
{
    public class PurchasePage : PageBase
    {
        public PurchasePage(IWebDriver driver)
            : base(driver)
        {
            Wait.Until(c => Phones.Count() > 0);
        }

        private IWebElement ProductGrid => Wait.Until(c => c.FindElement(By.Id("grid-items")));

        private IEnumerable<IWebElement> Phones => Wait.Until(c => ProductGrid.FindElementsByDataTestId("product-item-upcoming-false-TnseWapi"));

        public PhoneDetailsPage SelectPhone(int phone)
        { 
            Press(Phones.ElementAt(phone + 1));

            return new PhoneDetailsPage(_driver);
        }        
    }
}
