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

namespace SPIF
{
    public partial class UcWorkloadChart : UserControl
    {
        public Theme theme;
        private TableLayoutPanel tlpChart;

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
                    ((ProgressBarEx)control).background = theme.tint1;
                    ((ProgressBarEx)control).textColor = theme.text;
                }
            }


        }
        public void disposeChart()
        {
            
            this.Controls.Remove(tlpChart);
            tlpChart.Dispose();
        }

        public void initChart()
        {
            // Tablelayoutpanel to house the chart
            tlpChart = new TableLayoutPanel();
            tlpChart.ColumnCount = 2;
            tlpChart.RowCount = 0;
            tlpChart.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpChart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpChart.AutoScroll = true;

            this.Controls.Add(tlpChart);

            tlpChart.Dock = DockStyle.Fill;
        }

        public void generateChart(List<Record> records, bool project)
        {
            // Calculate total time
            decimal totaltime = 0;
            foreach (Record rec in records)
            {
                totaltime += rec.minutes;
            }

            records = records.OrderByDescending(o => o.minutes).ToList();

            // Draw name + progressbar in seperate row
            int currentRow = -1;

            foreach(Record rec in records)
            {
                currentRow++;
                tlpChart.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
                tlpChart.RowCount += 1;
                Label name = new Label();
                name.AutoSize = true;
                name.ForeColor = theme.text;

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
                
                ProgressBarEx barTime = new ProgressBarEx(theme.text, theme.background, theme.highlight);
                barTime.ForeColor = theme.highlight;
                barTime.BackColor = theme.highlight;
                barTime.Maximum = (int)totaltime;
                barTime.Minimum = 0;
                barTime.Dock = DockStyle.Fill;
                barTime.Value = (int)(rec.minutes);
                barTime.CustomText = rec.minutes.ToString() + " min (" + ((int)Math.Round((double)(100 * (double)rec.minutes) / (double)totaltime)).ToString() + "%)";

                tlpChart.Controls.Add(barTime, 1, currentRow);
            }

            //To fill remaining space
            tlpChart.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpChart.RowCount += 1;
        }
    }
}
