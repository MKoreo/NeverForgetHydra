using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeverForgetHydra
{
    public partial class FormChangelog : Form
    {
        public FormChangelog(string[] lines, MessageBoxButtons choice)
        {
            InitializeComponent();
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

            if (choice == MessageBoxButtons.OK)
            {
                btnCancel.Enabled = false;
            }       
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormChangelog_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (!btnCancel.Enabled && DialogResult != DialogResult.OK)
            {
                e.Cancel = true;
                DialogResult bla = MessageBox.Show("Skip the update? Don't think so buddy.", "Nice try", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
