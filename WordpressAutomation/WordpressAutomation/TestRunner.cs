using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Threading.Tasks;
using WordPressTests;

namespace WordpressAutomation
{
    public class TestRunner
    {
        static void Main(string[] args) {
            try
            {
                ///Initialize
                Driver.Initialize();

                ///Login Methods

                LoginPage.GoTo();
                LoginPage.LogInAs("arun").withPassword("arun12").Login();
                Assert.IsTrue(Driver.Instance.Title == "Dashboard ‹ iBlog — WordPress");
                Assert.IsTrue(DashboardPage.IsAt, "Failed to Login");

                ///Cleanup Methods
                Driver.Close();
            }
            catch (Exception e)
            {

                //Driver.Close();
            }
        }
    }
}
