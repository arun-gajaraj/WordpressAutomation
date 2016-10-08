using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;
using OpenQA.Selenium;
using System.Linq;

namespace WordPressTests
{
    [TestClass]
    public class LoginTests
    {

        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void login()
        {
            LoginPage.GoTo();
            LoginPage.LogInAs("arun").withPassword("arun123").Login();
            Assert.IsTrue(Driver.Instance.Title.StartsWith("Dashboard ‹"));
            Assert.IsTrue(DashboardPage.IsAt, "Failed to Login");
        }

        [TestCleanup]
        public void Cleanup() {
            Driver.Close();
        }
        
    }
}
