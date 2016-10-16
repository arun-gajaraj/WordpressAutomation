using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WordpressAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static IWebDriver Initialize() {
            Instance = new ChromeDriver(@"C:\iCode\Selenium\Drivers");
            Instance.Manage().Timeouts().ImplicitlyWait(System.TimeSpan.FromSeconds(5));
            return Instance;
        }

        public static void Close()
        {
            Instance.Close();
        }

        public static string BaseAddress 
        {
            get 
            {
                return @"http://localhost:8080/wp/"; 
            }
        }
    }
}         