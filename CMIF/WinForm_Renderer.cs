using CMDT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMIF
{
    //Common Interface Class: Winform Renderer to render menustrip with other colours
    //Uses: CMDT.Theme
    public class Winform_Renderer : ToolStripProfessionalRenderer
    {
        public Winform_Renderer(Theme theme) : base(new MyColors(theme)) { }
    }

    public class MyColors : ProfessionalColorTable
    {
        private Theme theme;
        public MyColors (Theme theme)
        {
            this.theme = theme;
        }
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return theme.background;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return theme.background;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return theme.background;
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return theme.background;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return theme.tint1;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return theme.tint1;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return theme.highlight;
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return theme.tint1;
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return theme.tint1;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return theme.background;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return theme.background;
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return theme.tint2;
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return theme.tint2;
            }
        }
    }
}
