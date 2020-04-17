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
        public Theme theme;
        public workLog log;
        private UcWorkloadChart ucWorkloadChart;
        

        public UcStatistics()
        {
            InitializeComponent();
        }
        
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

        public void generate (List<Record> records)
        {
            ucWorkloadChart.generateChart(records, true);
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpEnd.Value.Date.AddDays(0);
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpEnd.Value.Date.AddDays(-7);
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            dtpStart.Value = dtpEnd.Value.Date.AddDays(-365);
        }

        private void btnMonth_MouseClick(object sender, MouseEventArgs e)
        {
            int[] daysPerMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int currentMonth = DateTime.Now.Month;
            dtpStart.Value = dtpEnd.Value.Date.AddDays(-daysPerMonth[currentMonth]);
        }

        private void btnUpdate_ClickAsync(object sender, EventArgs e)
        {
            ucWorkloadChart.disposeChart();
            ucWorkloadChart.initChart();

            // Check Type
            if ((string)cbType.SelectedItem == "")
            {
                cbType.SelectedIndex = 0;
            }

            try
            {
                _ = test();
            }
            catch (Exception ex) { }

            // Generate Chart
         }
        private async Task test()
        {
            bool project = ((string)cbType.SelectedItem == "Project" ? true : false);
            await ucWorkloadChart.generateChart(log.getRecordsBetweenDates(dtpStart.Value.Date, dtpEnd.Value.Date, project), project);

        }
    }
}
