using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPDT;
using CMIF;
using CMLO;
using CMDT;
using System.Globalization;

namespace SPIF
{
    public partial class UcWorkloadChart : UserControl
    {
        private Theme theme;
        private TableLayoutPanel tlpChart;
        private List<Label> labels;
        private List<ProgressBarEx> progressbars;

        public UcWorkloadChart(ref Theme theme) : base()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.theme = theme;

            initChart();
        }

        public void applyTheming()
        {
            // Set backcolor of chart
            this.BackColor = theme.tint1;

            // Set label textcolor
            foreach (Control control in tlpChart.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    ((Label)control).ForeColor = theme.text;
                }

                if (control.GetType() == typeof(ProgressBarEx))
                {
                    ((ProgressBarEx)control).foreground = theme.highlight;
                    ((ProgressBarEx)control).background = theme.tint2;
                    ((ProgressBarEx)control).textColor = theme.text;
                }
            }
        }

        // Removed from designer and added tlpChart
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                tlpChart.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void disposeChart()
        {
            // Dispose elements that make up graph
            foreach(Label lbl in labels) { lbl.Dispose(); }
            foreach(ProgressBarEx pro in progressbars) { pro.Dispose(); }

            // Dispose the actual chart (tablelayout)
            this.Controls.Remove(tlpChart);
            tlpChart.Dispose();
        }

        public void initChart()
        {
            // Dispose old chart if not done so already
            if (tlpChart != null)
            {
                disposeChart();
            }

            // Tablelayoutpanel to house the chart
            tlpChart = new TableLayoutPanel();
            tlpChart.ColumnCount = 2;
            tlpChart.RowCount = 0;
            tlpChart.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpChart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpChart.AutoScroll = true;
            tlpChart.HorizontalScroll.Enabled = false;
            tlpChart.Dock = DockStyle.Fill;
            this.Controls.Add(tlpChart);

            // To be able to make changes/dispose afterwards
            labels = new List<Label>();
            progressbars = new List<ProgressBarEx>();
        }

        public async Task generateChartAsync(List<Record> records, bool project)
        {
            // Make sure records is not empty list
            if (records == null)
            {
                throw new ArgumentNullException(nameof(records));
            }

            // Calculate total time
            decimal totaltime = 0;
            decimal maxTime = 0;

            foreach (Record rec in records)
            {
                totaltime += rec.minutes;
                maxTime = (rec.minutes > maxTime ? rec.minutes : maxTime);
            }

            records = records.OrderByDescending(o => o.minutes).ToList();

            // Draw name + progressbar in seperate row
            int currentRow = -1;

            foreach(Record rec in records)
            {
                currentRow++;
                tlpChart.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
                tlpChart.RowCount += 1;

                Label name = new Label
                {
                    AutoSize = true,
                    ForeColor = theme.text
                };
                labels.Add(name);

                if (project)
                {
                    name.Text = rec.projectCode;
                } else
                {
                    name.Text = rec.projectCode;
                    name.Text += " - " + rec.subject;
                }

                name.Text = Generic.fixStringLength(name.Text, 40, true);
                tlpChart.Controls.Add(name, 0, currentRow);

                ProgressBarEx barTime;
                if (rec.minutes > maxTime / 2)
                {
                    barTime = new ProgressBarEx(theme.textHighlight, theme.tint2, theme.highlight);
                }
                else
                {
                    barTime = new ProgressBarEx(theme.text, theme.tint2, theme.highlight);
                }
                progressbars.Add(barTime);

                barTime.ForeColor = theme.highlight;
                barTime.BackColor = theme.highlight;
                barTime.Maximum = (int)maxTime + 40;
                barTime.Minimum = 0;
                barTime.Dock = DockStyle.Fill;
                barTime.Value = (int)(rec.minutes);

                
                barTime.CustomText = Generic.convertMinutesToHoursString(rec.minutes) + " (" + ((int)Math.Round(100 * (double)rec.minutes / (double)totaltime)).ToString(CultureInfo.InvariantCulture) + "%)";

                tlpChart.Controls.Add(barTime, 1, currentRow);

                // Prevent horizontal scrollbar from appearing when vetical scrollbar is drawn
                int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
                tlpChart.Padding = new Padding(0, 0, vertScrollWidth, 0);
            }

            //To fill remaining space (Prevent last chart to get streched)
            tlpChart.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpChart.RowCount += 1;
        }
    }
}
