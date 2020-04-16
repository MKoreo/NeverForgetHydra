using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CMIF
{
    public class ProgressBarEx : ProgressBar
    {
        public Color textColor;
        public Color background;
        public Color foreground;

        public String CustomText { get; set; }

        public ProgressBarEx(Color textColor, Color background, Color foreground) : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.textColor = textColor;
            this.background = background;
            this.foreground = foreground;
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // None... Helps control the flicker.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //No inset needed, cause we change background color.
            //const int inset = 2; // A single inset value to control the sizing of the inner rect.

            //Load image offscreen, prevent flickering
            using (Image offscreenImage = new Bitmap(this.Width, this.Height))
            {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage))
                {
                    //Create rectangle of complete progressbar (background)
                    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                    
                    if (ProgressBarRenderer.IsSupported)
                        ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);

                    //No inset needed, we don't use the border.
                    //rect.Inflate(new Size(-inset, -inset)); // Deflate inner rect.
                    LinearGradientBrush brushBackground = new LinearGradientBrush(rect, background, background, LinearGradientMode.Vertical);
                    offscreen.FillRectangle(brushBackground, rect);

                    rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));
                    if (rect.Width == 0) rect.Width = 1; // Can't draw rec with width of 0.

                    LinearGradientBrush brushForeground = new LinearGradientBrush(rect, foreground, foreground, LinearGradientMode.Vertical);
                    //offscreen.FillRectangle(brush, inset, inset, rect.Width, rect.Height);
                    offscreen.FillRectangle(brushForeground, 0, 0, rect.Width, rect.Height);


                    //Write text on progressbar (middle)
                    using (Font f = new Font("Verdana", 7))
                    {

                        SizeF len = offscreen.MeasureString(CustomText, f);
                        // Calculate the location of the text (the middle of progress bar)
                        // Point location = new Point(Convert.ToInt32((rect.Width / 2) - (len.Width / 2)), Convert.ToInt32((rect.Height / 2) - (len.Height / 2)));
                        Point location = new Point(Convert.ToInt32((Width / 2) - len.Width / 2), Convert.ToInt32((Height / 2) - len.Height / 2));
                        // The commented-out code will centre the text into the highlighted area only. This will centre the text regardless of the highlighted area.
                        // Draw the custom text
                        Brush brushText = new SolidBrush(textColor);
                        offscreen.DrawString(CustomText, f, brushText, location);
                    }

                    e.Graphics.DrawImage(offscreenImage, 0, 0);
                    offscreenImage.Dispose();
                }
            }

            
        }
    }
}