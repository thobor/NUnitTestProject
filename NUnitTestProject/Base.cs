using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;

namespace NUnitTestProject
{
    public abstract class Base
    {
        public static IConfiguration settings;
        public IWebDriver _driver;

        public Base()
        {
            settings = new ConfigurationBuilder()
            .AddJsonFile("settings.json")
            .Build();
        }
    }
}
