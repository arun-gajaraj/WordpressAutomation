using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WordpressAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static IWebDriver Initialize() {
            Instance = new ChromeDriver(@"E:\Work\Selenium\CSharp");
            Instance.Manage().Timeouts().ImplicitlyWait(System.TimeSpan.FromSeconds(5));
            return Instance;
        }


    }
}