using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordpressAutomation.Util
{
    public class Reports
    {
        public static ExtentReports ReportInstance { get; set; }
        
        public static void InitExtenetReport()
        {
            ReportInstance = new ExtentReports(@"E:\WordPressReports", false, DisplayOrder.NewestFirst);
        }        
    }
}
