using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;
using OpenQA.Selenium;
using System.Linq;
using WordpressAutomation.Util;


namespace WordPressTests
{
    [TestClass]
    public class LoginTests : WordPressTest
    {



        [TestMethod]
        public void login()
        {
            Assert.IsTrue(Driver.Instance.Title.StartsWith("Dashboard ‹"));
            Assert.IsTrue(DashboardPage.IsAt, "Failed to Login");
            FileLogger.WriteToLog("Logged In");      
        }


        
    }
}
