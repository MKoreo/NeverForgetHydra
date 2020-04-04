using CMDT;
using CMIF;
using SPDT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPIF
{
    public partial class FormHighlightColor : ThemedForm
    {
        public string feedback;
        public FormHighlightColor(FormMain test, Theme theme, Settings settings) : base(settings)
        {
            InitializeComponent();
            this.theme = theme;
            this.settings = settings;
            applyTheming();
            applyAddTheming();
        }

        private void applyAddTheming()
        {
            //Add button specific
            btnSend.BackColor = theme.highlight;
            btnSend.ForeColor = theme.text;

            lblFeedback.BackColor = theme.tint1;
            lblFeedback.ForeColor = theme.text;

            rtbFeedback.BackColor = theme.background;
            rtbFeedback.ForeColor = theme.text;

            //Update Window
            this.Invalidate();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            feedback = rtbFeedback.Text;

            this.Close();
        }
    }
}
