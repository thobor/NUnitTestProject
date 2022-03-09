using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;

namespace NUnitTestProject
{
    public class TestBase : Base
    {       

          

        [SetUp]
        public void Setup()
        {
            switch (settings["Browser"])
            {
                case "Chrome":
                    _driver = WebdriverSetup.SetupChrome();
                    break;
                case "Edge":
                    _driver = WebdriverSetup.SetupEdge();
                    break;
                default:                    
                    break;
            }

            
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}