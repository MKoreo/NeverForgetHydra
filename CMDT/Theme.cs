using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMDT
{
    public class Theme
    {
        public enum themeStyle
        {
            light,
            dark
        }

        //public themeStyle style { get; set; }
        public Color highlight { get; set; }
        public Color textHighlight { get; set; }
        public Color background { get; set; }
        public Color text { get; set; }
        public Color tint1 { get; set; }
        public Color tint2 { get; set; }

        public void generateColours(themeStyle style)
        {
            //Set colours based on theme
            if (style == themeStyle.light)
            {
                //highlight = Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                background = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                text = Color.Black;
                textHighlight = Color.White;
                tint2 = Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
                tint1 = Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            }
            else if (style == themeStyle.dark)
            {
                //highlight = Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                background = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
                text = Color.White;
                textHighlight = Color.White;
                tint1 = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))); 
                tint2 = Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            }
        }
    }
}
