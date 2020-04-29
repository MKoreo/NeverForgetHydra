using CMDT;
using SPDT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMIF
{
    public partial class ThemedForm : Form
    {
        public Settings settings;
        public Theme theme;

        public ThemedForm()
        {

        }
        public ThemedForm(ref Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
            initTheme();
            applyTheming();
        }

        public void initTheme()
        {
            theme = new Theme();
        }
        public void applyTheming()
        {
            //update colours
            theme.generateColours(settings.style);
            theme.highlight = Color.FromArgb(settings.highlightColor);

            //General Theming
            this.BackColor = theme.background;
            foreach (Control c in this.Controls)
            {
                c.BackColor = theme.background;
                c.ForeColor = theme.text;
            }

            //Update Window
            this.Invalidate();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ThemedForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 256);
            this.Name = "ThemedForm";
            this.Tag = "test";
            this.ResumeLayout(false);
        }
    }
}
