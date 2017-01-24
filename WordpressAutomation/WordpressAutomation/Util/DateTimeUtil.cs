using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation.Util
{
    public class DateTimeUtil
    {
        static DateTime now = DateTime.Now;

        public String GetDateTime() 
        {
            return now.ToString();
        }

    }
}
