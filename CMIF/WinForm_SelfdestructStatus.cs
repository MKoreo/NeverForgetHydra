using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CMIF
{
    // Common Interface Class: Selfdestruct status
    // Label that removes itself from existence after given period of time
    // No dependencies
    public class WinForm_SelfdestructStatus
    {
        private Timer selfDestruct;
        private ToolStripStatusLabel newStatus;

        private Decimal time;
        private Color temp1;
        private Color temp2;
        private int transparency;
        private int fadeFactor;

        //Creation of object sets parent and creates status
        public WinForm_SelfdestructStatus(StatusStrip strip, string status, decimal seconds, Color foreColor, Color backColor)
        {
            //Construct
            this.time = 10 * seconds;
            this.transparency = 255;
            this.selfDestruct = new Timer();
            this.fadeFactor = 255 / (int)time;
            this.temp1 = foreColor;
            this.temp2 = backColor;

            //Set timer values
            selfDestruct.Interval = (int)(100);
            selfDestruct.Tick += new EventHandler(destroyTimer);
            selfDestruct.Start();

            //Create Label
            newStatus = new ToolStripStatusLabel();
            newStatus.Text = status;
            newStatus.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            newStatus.ForeColor = Color.FromArgb(transparency, temp1);
            newStatus.BackColor = Color.FromArgb(transparency, temp2);

            //Space with other labels
            Padding margin = newStatus.Margin;
            margin.Left = 4;
            newStatus.Margin = margin;

            //Pass object
            strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { newStatus });
        }

        private void destroyTimer(object timer, EventArgs e)
        {
            //Decrease time
            time--;
            //If time not over, decrease transprency by fadefactor
            if (time != 0 && transparency > fadeFactor)
            {
                transparency = transparency - fadeFactor;

                newStatus.ForeColor = Color.FromArgb(transparency, temp1);
                newStatus.BackColor = Color.FromArgb(transparency, temp2);
            } else
            {
                newStatus.Dispose();
            }

        }
    }
}
