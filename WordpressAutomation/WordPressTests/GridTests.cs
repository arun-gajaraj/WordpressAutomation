using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordpressAutomation;

namespace WordPressTests
{
    [TestClass]
    public class GridTests : WordPressTest
    {
        static IWebDriver driver;
        [TestInitialize]
        public void Setup() 
        {
            
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities = DesiredCapabilities.Chrome();
            capabilities.IsJavaScriptEnabled=true;
            //capabilities.SetCapability("platform", new Platform(PlatformType.Windows));
            capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));

            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);
        }

        [TestMethod]
        public void Navigate_to_Google_In_Grid() 
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }



    }
}
