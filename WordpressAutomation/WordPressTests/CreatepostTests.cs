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
    public class CreatepostTests
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

            NewPostPage.Goto();
            NewPostPage.createPost("New Post Tiltle")
                .withBody("The BODY!")
                .Publish();

            NewPostPage.GoToNewPost();

            //Assert.AreEqual( PostPage.Title , "New Post Tiltle","Not the new post!");

            Assert.AreEqual( PostPage.Title , "New Post Tiltle"+" - iBlog","Not the new post!");



        }





        [TestCleanup]
        public void Cleanup()
        {
            Driver.Instance.Quit();
            //Driver.Close();
            
        }
    }
}
