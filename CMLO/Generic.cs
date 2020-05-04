using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMLO
{
    public static class Generic
    {
        public static bool isNullOrEmpty (string testString)
        {
            if (testString == null)
            {
                return true;
            }

            if (testString.Length == 0)
            {
                return true;
            }

            return false;
        }
        public static string fixStringLength(string str, int maxChars, bool doublePoint)
        {
            if (str.Length > maxChars)
            {
                str = str.Substring(0, maxChars);
                str += "...";
            }
            if (doublePoint)
            {
                str += ":";
            }
            return str;
        }

        public static string convertMinutesToHoursString(decimal minutes)
        {
            TimeSpan time = TimeSpan.FromMinutes((double)minutes);
            // Get string of minutes if < 60 or hours and minutes otherwise
            return time.ToString((minutes > 59 ? @"hh\hmm\m" : @"mm\m"), CultureInfo.InvariantCulture);
        }
    }
}
