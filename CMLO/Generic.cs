using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMLO
{
    public static class Generic
    {
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
    }
}
