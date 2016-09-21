using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class Class1
    {
        public void Go() {
            //var driver = new FirefoxDriver();
            IWebDriver driver = new ChromeDriver(@"E:\Work\Selenium\CSharp");

            driver.Navigate().GoToUrl(@"http://localhost:8080/wp/wp-login.php");
            //driver.Navigate().GoToUrl("http://google.com");

            //driver.go
        }

        public static void Main() {
            var cl = new Class1();
            cl.Go();
        }
        
    }
}
