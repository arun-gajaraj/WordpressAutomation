using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class NewPostPage
    {
        public static void Goto()
        {
            Driver.Instance.Navigate().GoToUrl("");
        }

        public static CreatepostCommand createPost(string v)
        {
            return new CreatepostCommand(v);   
        }

        public class CreatepostCommand
        {
            public static String TitleText;
            public static String PostBody;

            public CreatepostCommand(String v)
            {
                TitleText = v;
            }

            public CreatepostCommand withBody(string v)
            {
                PostBody = v;
                return this;
            }

            public void Publish()
            {
                //Click on the Publish Button with other inputs
                Driver.Instance.FindElement(By.Id("")).Click();


            }
        }

        public static void GoToNewPost()
        {
            Driver.Instance.Navigate().GoToUrl("");
        }
    }
}
