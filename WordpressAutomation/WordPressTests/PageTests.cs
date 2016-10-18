using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordpressAutomation;
using WordpressAutomation;

namespace WordPressTests
{
    [TestClass]
    public class PageTests : WordPressTest
    {


        [TestMethod]
        public void Can_create_a_new_post()
        {

            ListPostsPage.GoTo(WordpressAutomation.ListPostsPage.PostType.Page);
            ListPostsPage.Selectpost();
                  


        }




    }
}
