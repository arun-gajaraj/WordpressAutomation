using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordpressAutomation;

namespace WordPressTests
{
    [TestClass]
    public class PageTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            Driver.Instance.Manage().Window.Maximize();
        }

        [TestMethod]
        public void Can_create_a_new_post()
        {
            LoginPage.GoTo();
            LoginPage.LogInAs("arun").withPassword("arun123").Login();

            ListPostsPage.GoTo(WordpressAutomation.ListPostsPage.PostType.Page);
            ListPostsPage.Selectpost();


        }



        [TestCleanup]
        public void Cleanup()
        {
            Driver.Instance.Quit();
            //Driver.Close();

        }
    }
}
