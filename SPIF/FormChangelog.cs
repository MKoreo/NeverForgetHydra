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
    public partial class FormChangelog : ThemedForm
    {
        public FormChangelog(Theme theme, Settings settings) : base(settings)
        {
            InitializeComponent();
            this.theme = theme;
            this.settings = settings;
            applyTheming();
            applyAddTheming();

            string[] lines = System.IO.File.ReadAllLines(@"version.ini");
            foreach (string line in lines)
            {
                int length = rtbChangelog.Text.Length;
                rtbChangelog.AppendText(line + "\r\n");

                if (line.Contains("*"))
                {
                    rtbChangelog.Select(length, line.Length);
                    rtbChangelog.SelectionFont = new Font("Consolas", 12, FontStyle.Bold);
                }
            }
        }

        private void applyAddTheming()
        {
            //Add button specific
            btnClose.BackColor = theme.highlight;
            btnClose.ForeColor = theme.text;

            lblChangelog.BackColor = theme.tint1;
            lblChangelog.ForeColor = theme.text;

            rtbChangelog.BackColor = theme.background;
            rtbChangelog.ForeColor = theme.text;

            //Update Window
            this.Invalidate();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
