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
                LoginPage.doLogin();
                






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
