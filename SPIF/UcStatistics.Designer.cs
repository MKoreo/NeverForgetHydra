using CMIF;

namespace SPIF
{
    partial class UcStatistics
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpStatistics = new System.Windows.Forms.TableLayoutPanel();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnDay = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tlpStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpStatistics
            // 
            this.tlpStatistics.ColumnCount = 10;
            this.tlpStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatistics.Controls.Add(this.btnYear, 8, 0);
            this.tlpStatistics.Controls.Add(this.btnWeek, 6, 0);
            this.tlpStatistics.Controls.Add(this.lblEndDate, 3, 0);
            this.tlpStatistics.Controls.Add(this.dtpEnd, 4, 0);
            this.tlpStatistics.Controls.Add(this.dtpStart, 2, 0);
            this.tlpStatistics.Controls.Add(this.lblStartDate, 1, 0);
            this.tlpStatistics.Controls.Add(this.btnDay, 5, 0);
            this.tlpStatistics.Controls.Add(this.lblType, 1, 1);
            this.tlpStatistics.Controls.Add(this.cbType, 2, 1);
            this.tlpStatistics.Controls.Add(this.lblFilter, 3, 1);
            this.tlpStatistics.Controls.Add(this.cbProject, 4, 1);
            this.tlpStatistics.Controls.Add(this.btnMonth, 7, 0);
            this.tlpStatistics.Controls.Add(this.btnUpdate, 5, 1);
            this.tlpStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStatistics.Location = new System.Drawing.Point(0, 0);
            this.tlpStatistics.Name = "tlpStatistics";
            this.tlpStatistics.RowCount = 3;
            this.tlpStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatistics.Size = new System.Drawing.Size(863, 494);
            this.tlpStatistics.TabIndex = 0;
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYear.FlatAppearance.BorderSize = 0;
            this.btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYear.Location = new System.Drawing.Point(749, 3);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(69, 24);
            this.btnYear.TabIndex = 6;
            this.btnYear.Text = "Year";
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWeek.FlatAppearance.BorderSize = 0;
            this.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeek.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWeek.Location = new System.Drawing.Point(599, 3);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(69, 24);
            this.btnWeek.TabIndex = 5;
            this.btnWeek.Text = "Week";
            this.btnWeek.UseVisualStyleBackColor = false;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndDate.Location = new System.Drawing.Point(284, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(94, 30);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End date:";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(384, 3);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(134, 25);
            this.dtpEnd.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(144, 3);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(134, 25);
            this.dtpStart.TabIndex = 0;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartDate.Location = new System.Drawing.Point(44, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 30);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDay
            // 
            this.btnDay.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDay.FlatAppearance.BorderSize = 0;
            this.btnDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDay.Location = new System.Drawing.Point(524, 3);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(69, 24);
            this.btnDay.TabIndex = 4;
            this.btnDay.Text = "Day";
            this.btnDay.UseVisualStyleBackColor = false;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Location = new System.Drawing.Point(44, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(94, 30);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbType
            // 
            this.cbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(144, 33);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(134, 25);
            this.cbType.TabIndex = 8;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilter.Location = new System.Drawing.Point(284, 30);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(94, 30);
            this.lblFilter.TabIndex = 9;
            this.lblFilter.Text = "Filter:";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbProject
            // 
            this.cbProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(384, 33);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(134, 25);
            this.cbProject.TabIndex = 10;
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMonth.FlatAppearance.BorderSize = 0;
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMonth.Location = new System.Drawing.Point(674, 3);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(69, 24);
            this.btnMonth.TabIndex = 11;
            this.btnMonth.Text = "Month";
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.tlpStatistics.SetColumnSpan(this.btnUpdate, 4);
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(524, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(294, 24);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UcStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlpStatistics);
            this.Font = new System.Drawing.Font("Verdana", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcStatistics";
            this.Size = new System.Drawing.Size(863, 494);
            this.tlpStatistics.ResumeLayout(false);
            this.tlpStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpStatistics;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnUpdate;
    }
}
