using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace NUnitTestProject
{
    public class WebdriverSetup
    {
        public static IWebDriver SetupChrome()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            return new ChromeDriver(options);
        }

        internal static IWebDriver SetupEdge()
        {
            var options = new EdgeOptions();
            options.AddArgument("--start-maximized");
            return new EdgeDriver(options);
        }
    }
}
