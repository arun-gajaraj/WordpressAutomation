using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordpressAutomation;
using System.Configuration;

namespace WordPressTests
{
    [TestClass]
    public class CreatepostTests : WordPressTest
    {


        [TestMethod]
        public void Can_create_a_new_post()
        {


            string title = DateTime.Now.ToString();
                //ConfigurationManager.AppSettings["newTitle"];
            string body = ConfigurationManager.AppSettings["postBody"]; ;
            NewPostPage.Goto();
            NewPostPage.createPost(title)
                .withBody(body)
                .Publish();

            NewPostPage.GoToNewPost();

            //Assert.AreEqual( PostPage.Title , title+" - iBlog","Not the new post!");

            string titleString = Driver.Instance.FindElement(By.CssSelector(".site-title>a")).Text;

            Assert.AreEqual(Driver.Instance.Title, title + " – " + titleString);


        }

        
    }
}
