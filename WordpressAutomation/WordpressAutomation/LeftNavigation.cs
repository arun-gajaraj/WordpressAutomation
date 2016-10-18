using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordpressAutomation
{
    public  class LeftNavigation
    {
        public class Pages 
        {
            public class AddNew
            {
                public static void Select() 
                {
                    MenuSelelector.Select("menu-pages", "Add New");                   
                }
            }

            public class AllPages
            {
                public static void Select()
                {
                    MenuSelelector.Select("menu-pages", "All Pages");
                    
                }
            }
        }
    }

    class MenuSelelector
    {
        internal static void Select(string topLevelMenuId, string subLevelLinkText)
        {
            //Driver.Instance.FindElement(By.LinkText("Pages")).Click();
            var menuPosts = Driver.Instance.FindElement(By.Id(topLevelMenuId));
            menuPosts.Click();

            var addNewPost = Driver.Instance.FindElement(By.LinkText(subLevelLinkText));
            addNewPost.Click();
        }
    }
}
