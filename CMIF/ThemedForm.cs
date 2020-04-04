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
        public Settings settings { get; set; }
        public Theme theme { get; set; }

        public ThemedForm()
        {

        }
        public ThemedForm(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
            applyTheming();
        }

        public void applyTheming()
        {
            theme = new Theme();

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
