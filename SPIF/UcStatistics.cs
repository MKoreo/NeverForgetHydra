using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMIF;
using SPDT;
using CMDT;

namespace SPIF
{
    public partial class UcStatistics : UserControl
    {
        // Instances
        private Theme theme;
        private workLog log;

        private UcWorkloadChart ucWorkloadChart;
        
        // Empty constructor
        public UcStatistics()
        {
            InitializeComponent();
        }
        // Constructor
        public UcStatistics(ref Theme theme)
        {
            InitializeComponent();

            // Properties
            this.Dock = DockStyle.Fill;
            this.theme = theme;

            // Init comboBox Type
            cbType.Items.Add("Project");
            cbType.Items.Add("Project and Subject");

            // Init chart UC
            ucWorkloadChart = new UcWorkloadChart(ref theme);
            ucWorkloadChart.Padding = new Padding(10);
            ucWorkloadChart.Visible = true;
            ucWorkloadChart.Name = "chart";

            // Add Chart to TLP: 3rd row + full width
            tlpStatistics.Controls.Add(ucWorkloadChart, 0, 2);
            tlpStatistics.SetColumnSpan(ucWorkloadChart, tlpStatistics.ColumnCount);
            applyTheming();
        }
        // Theming
        public void applyTheming()
        {
            this.BackColor = theme.tint1;
            btnDay.ForeColor = theme.text;
            btnDay.BackColor = theme.tint2;
            btnWeek.ForeColor = theme.text;
            btnWeek.BackColor = theme.tint2;
            btnMonth.ForeColor = theme.text;
            btnMonth.BackColor = theme.tint2;
            btnYear.ForeColor = theme.text;
            btnYear.BackColor = theme.tint2;
            btnUpdate.ForeColor = theme.textHighlight;
            btnUpdate.BackColor = theme.highlight;

            if (ucWorkloadChart != null)
            {
                ucWorkloadChart.applyTheming();
            }
        }
        // Disposing
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                ucWorkloadChart.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Setters
        public void setWorklog(workLog log)
        {
            this.log = log;
        }
        // Methods
        private async Task generateChartAsync()
        {
            bool project = ((string)cbType.SelectedItem == "Project" ? true : false);
            await ucWorkloadChart.generateChartAsync(log.getRecordsBetweenDates(dtpStart.Value.Date, dtpEnd.Value.Date, project), project).ConfigureAwait(true);
        }

        // Event handlers
        // Date buttons
        private void btnDay_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpEnd.Value.Date.AddDays(0);
        }
        private void btnWeek_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpEnd.Value.Date.AddDays(-7);
        }
        private void btnMonth_Click(object sender, EventArgs e)
        {
            int[] daysPerMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int currentMonth = DateTime.Now.Month;
            dtpStart.Value = dtpEnd.Value.Date.AddDays(-daysPerMonth[currentMonth]);
        }
        private void btnYear_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpEnd.Value.Date.AddDays(-365);
        }

        // Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Create new chart
            ucWorkloadChart.initChart();

            // Determine chart type to generate
            if (cbType.SelectedValue is null) { cbType.SelectedIndex = 1; }

            // Generate chart in an asynchronous way
            _ = generateChartAsync();
        }
    }
}
