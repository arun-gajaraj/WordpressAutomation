using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordpressAutomation;
using WordpressAutomation.Util;


namespace WordPressTests
{
    public class WordPressTest
    {
        /// <summary>
        /// Initialises the Webdriver with the driver of your choice, here a chromedriver.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();            
            Driver.Instance.Manage().Window.Maximize();
            //Logger
            FileLogger.WriteToLog("Driver Initialized");

            //ExtentReport
            Reports.InitExtenetReport();


            string username = ConfigurationManager.AppSettings["username"];
            string password = ConfigurationManager.AppSettings["password"];

            LoginPage.GoTo();
            LoginPage.LogInAs(username).withPassword(password).Login();
        }

        /// <summary>
        /// Cleanup Method to close the Webdriver Instance
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Instance.Quit();
            //Driver.Close();
            FileLogger.WriteToLog("Execution Ran. Killing drivers!"); 

        }
    }
}
