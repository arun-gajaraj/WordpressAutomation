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
         LeftNavigation.Pages.AddNew.Select();   
        }

        public static CreatepostCommand createPost(string v)
        {
            return new CreatepostCommand(v);   
        }

        public class CreatepostCommand
        {
            public static String TitleText;
            public static String PostBody;

            public CreatepostCommand(String title)
            {
                TitleText = title;
            }

            public CreatepostCommand withBody(string bodytext)
            {
                PostBody = bodytext;
                return this;
            }

            public void Publish()
            {
                //Click on the Publish Button with other inputs
                Driver.Instance.FindElement(By.XPath(@"//*[@id='titlewrap']/input")).SendKeys(TitleText);
                //Driver.Instance.FindElement(By.CssSelector("#tinymce")).SendKeys(PostBody);
                Driver.Instance.SwitchTo().Frame("content_ifr");
                Driver.Instance.SwitchTo().ActiveElement().SendKeys(PostBody);
                Driver.Instance.SwitchTo().DefaultContent();

                Driver.Instance.FindElement(By.Id("publish")).Click();


            }
        }

        public static void GoToNewPost()
        {
            Driver.Instance.FindElement(By.LinkText("View post")).Click();
        }
    }
}
