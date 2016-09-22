using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;

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
            Assert.IsTrue(Driver.Instance.Title == "Dashboard ‹ iBlog — WordPress");
        }
        
    }
}
