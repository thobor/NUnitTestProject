using NUnit.Framework;

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
                    throw new System.Exception("Incompatible browser selected");
            }
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}