using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation.Util
{
    public class FileLogger 
    {
        public static string logPath = @"C:\iCode\Selenium\Wordpress\WordpressAutomation\WordpressAutomation\Log";
        public static string fileName = "log.txt";

        public static void WriteToLog(string message)
        {
            var fileWriter = File.AppendText(logPath+@"\"+fileName);
            fileWriter.WriteLine(message);
            fileWriter.Close();
        }

        
    }
}
