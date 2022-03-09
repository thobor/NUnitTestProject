using NUnit.Framework;
using NUnitTestProject.PageObjects;
using System;

namespace NUnitTestProject.Tests
{
    public class Tests : TestBase
    {

        [Test]
        [TestOf("PhonePurchase")]
        public void PurchaseTest()
        {  
            var startpage = new StartPage(_driver);

            startpage.AcceptCookies();
            var purchasePage = startpage.GoToPurchasePhonesPage();

            var PhoneDetails = purchasePage.SelectPhone(1);

            PhoneDetails.SelectSubscriptions(new Random().Next(0, 5));
            PhoneDetails.SelectNumberOfUsers(new Random().Next(0, 5));
            PhoneDetails.SelectNewNumbers();
            var checkoutPage = PhoneDetails.Continue();

            Assert.AreEqual("Checkout order", checkoutPage.Title);
        }
    }
}