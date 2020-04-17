﻿using CMDT;
using SPIF;
using CMIF;
using SPDT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SPIF
{
    public partial class MainWindow : ThemedForm
    {
        //Ui timer
        System.Windows.Forms.Timer popupTimer = new System.Windows.Forms.Timer();

        //States
        private bool fileOpen = false; 
        private decimal minutesPassed = 0;

        enum View
        {
            records,
            statistics
        }
        View view = View.records;
        //Variables
        private workLog log;
        private UcStatistics ucStatistics;

        //Create system Tray Icon
        NotifyIcon trayIcon = new NotifyIcon();

        //Constructor
        public MainWindow(Settings settings) : base(settings)
        {
            // Default
            InitializeComponent();

            // Initialize timer, trayIcon
            initPopupTimer();

            // Theme
            applyTheming();
            applyAddTheming();

            // Init objects
            log = new workLog();

            // Init UI components
            initTrayIcon();
            initQuickSettingsPanel();
            initUcStatistics();
           

            //btnViewRecords.PerformClick();
        }
        // ------------------ Popup timer ------------------
        private void initPopupTimer()
        {
            //Interval = 60 * 1000ms * AmountOfMinutes
            popupTimer.Interval = (int)(60 * 1000); //Every minute
            popupTimer.Tick += new EventHandler(popupTimerTick);
        }
        private void popupTimerTick(object sender, EventArgs e)
        {
            minutesPassed += 1;
            if (minutesPassed == settings.minutesTillPopup && fileOpen)
            {
                popup();
                minutesPassed = 0;
            }

            updateTrayIcon();

            //Joke
            if (settings.showJokes)
            {
                updateStatus("A minute has passed... Life is slowly ticking away", 5, Color.Red);
            } else
            {
                updateStatus("A minute has passed");
            }
            
        }
        private void popup()
        {
            //Popup
            this.Show();

            // Attempted bugfix: When popup, only dropdown list shows.
            this.Invalidate();

            updateTimePassed();
            //Change to today
            dateTimePicker.Value = DateTime.Now;
            //Dropdown
            comboBoxWork.DroppedDown = true;
        }
        // ------------------ Themes and color ------------------
        // Main theming happens in derrived class: ThemedForm
        // Additional theming here
        public void applyAddTheming()
        {
            //Add button specific
            buttonAdd.BackColor = theme.textHighlight;
            buttonAdd.ForeColor = theme.highlight;

            //Back and forward button specific
            button_left.ForeColor = theme.background;
            button_right.ForeColor = theme.background;

            //MenuStrip specific
            menuStrip.Renderer = new Winform_Renderer(theme);
            menuStrip.ForeColor = theme.text;
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                item.ForeColor = theme.text;
                foreach (ToolStripMenuItem itemm in item.DropDownItems)
                {
                    itemm.ForeColor = theme.text;
                    foreach (ToolStripMenuItem itemmm in itemm.DropDownItems)
                    {
                        itemmm.ForeColor = theme.text;
                    }
                }
            }
            menuStrip.BackColor = theme.tint1;

            //DatagridView specific
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.BackColor = theme.tint1;
            cellStyle.ForeColor = theme.text;
            cellStyle.SelectionBackColor = theme.highlight;
            cellStyle.SelectionForeColor = theme.textHighlight;
            cellStyle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular);

            DataGridViewCellStyle altCellStyle = new DataGridViewCellStyle();
            altCellStyle.BackColor = theme.tint1;
            altCellStyle.ForeColor = theme.text;
            altCellStyle.SelectionBackColor = theme.highlight;
            altCellStyle.SelectionForeColor = theme.textHighlight;
            altCellStyle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular);

            DataGridViewCellStyle ColumnHeaderStyle = new DataGridViewCellStyle();
            ColumnHeaderStyle.BackColor = theme.tint1;               
            ColumnHeaderStyle.ForeColor = theme.text;
            ColumnHeaderStyle.SelectionBackColor = theme.background;
            ColumnHeaderStyle.SelectionForeColor = theme.textHighlight;
            ColumnHeaderStyle.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);

            DataGridViewCellStyle RowHeaderStyle = new DataGridViewCellStyle();
            RowHeaderStyle.BackColor = theme.tint1;
            RowHeaderStyle.ForeColor = theme.text;
            RowHeaderStyle.SelectionBackColor = theme.highlight;
            RowHeaderStyle.SelectionForeColor = theme.textHighlight;
            RowHeaderStyle.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);

            dataGridView.BackgroundColor = theme.tint1;
            dataGridView.ForeColor = theme.text;
            dataGridView.GridColor = theme.highlight;
            dataGridView.DefaultCellStyle = cellStyle;
            dataGridView.ColumnHeadersDefaultCellStyle = ColumnHeaderStyle;
            dataGridView.RowHeadersDefaultCellStyle = RowHeaderStyle;
            dataGridView.AlternatingRowsDefaultCellStyle = altCellStyle;
            dataGridView.RowHeadersVisible = false;

            //Layout specific
            tableLayoutPanelDate.BackColor = theme.highlight;
            tableLayoutPanelAdd.BackColor = theme.highlight;

            //QuicksettingsBox Specific
            tableLayoutPanelSettings.ForeColor = theme.text;
            tableLayoutPanelSettings.BackColor = theme.tint1;
            labelQuicksettings.BackColor = theme.highlight;
            labelQuicksettings.ForeColor = theme.textHighlight;
            btnResetTimer.BackColor = theme.tint2;
            btnResetTimer.ForeColor = theme.text;
            btnResetTimer.FlatAppearance.BorderSize = 0;

            //Statusstrip specific
            statusStrip.BackColor = theme.tint1;

            //View
            lblView.BackColor = theme.highlight;
            lblView.ForeColor = theme.textHighlight;
            btnViewRecords.BackColor = theme.tint2;
            btnViewRecords.ForeColor = theme.text;
            btnViewRecords.FlatAppearance.BorderSize = 0;
            btnViewStatistics.FlatAppearance.BorderSize = 0;
            btnViewStatistics.BackColor = theme.tint2;
            btnViewStatistics.ForeColor = theme.text;

            //Inside Statistics
            if (ucStatistics != null)
            {
                ucStatistics.applyTheming();
            }

            //Update mainWindow
            this.Invalidate();
            updateStatus("Theme applied");
        }
        // ------------------ Inits ----------------------------
        // Reminder: Init should be private
        private void initQuickSettingsPanel()
        {
            //Show or hide quicksettings
            FormSettings parser = new FormSettings(this, theme, settings);
            EventArgs empty = new EventArgs();
            CheckBox fakeCheckbox = new CheckBox();
            fakeCheckbox.Checked = settings.showQuickSettings;
            fakeCheckbox.Name = "cbShowQuickSettings";
            parser.handlerCheckedChanged(fakeCheckbox, empty);
            parser.btnSubmit_Click(fakeCheckbox, empty);
            parser.Dispose();
            fakeCheckbox.Dispose();
        }
        private void initComboBoxProject()
        {
            comboBoxProject.Items.Clear();

            foreach (Record rec in log.records)
            {
                if (!comboBoxProject.Items.Contains(rec.projectCode))
                {
                    //When pressing add, new project code needs to be added directly if not yet in it!
                    //Calling this method is to much overhead
                    comboBoxProject.Items.Add(rec.projectCode);
                }
            }
        }
        private void initTrayIcon()
        {
            trayIcon.Icon = SPIF.Properties.Resources.Hourglass;

            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon.
            updateTrayIcon();
            trayIcon.Visible = true;

            // Handle the DoubleClick event to activate the form.
            trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
        }
        private void initUcStatistics()
        {
            ucStatistics = new UcStatistics(ref theme);
        }
        // ------------------ Updates-------- ------------------
        // Reminder: Every update should be public and designed in such a way that this is allowed.
        public void updateRecords()
        {
            //Clear datagrid
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            //Add Columns
            dataGridView.Columns.Add("Date", "Date");
            dataGridView.Columns.Add("Project", "Project");
            dataGridView.Columns.Add("Time", "Time");
            dataGridView.Columns.Add("Subject", "Subject");
            dataGridView.Columns.Add("Remove", "");

            //Set Column settings
            foreach (DataGridViewColumn dc in dataGridView.Columns)
            {
                dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Add the data
            List<Record> records = log.getRecordsByDate(dateTimePicker.Value.Date);

            foreach (Record rec in records)
            {
                int rowId = dataGridView.Rows.Add();

                // Grab the new row!
                DataGridViewRow row = dataGridView.Rows[rowId];
                row.Cells["Date"].Value = rec.date.ToShortDateString();
                row.Cells["Project"].Value = rec.projectCode;
                row.Cells["Time"].Value = rec.minutes.ToString();
                row.Cells["Subject"].Value = rec.subject;
                row.Cells["Remove"].Value = "Delete";
                //Possible to change colour based on time value, but it ugly:
                //row.Cells["Time"].Style.BackColor = Color.FromArgb((int)rec.minutes, (int)rec.minutes, (int)rec.minutes);
            }
        }
        public void updateStatus(string text)
        {
            _ = new WinForm_SelfdestructStatus(statusStrip, text, 5, theme.textHighlight, theme.highlight);
        }
        public void updateStatus(string text, decimal seconds, Color back)
        {
            _ = new WinForm_SelfdestructStatus(statusStrip, text, seconds, theme.textHighlight, back);
        }
        public void updateQuickSettings()
        {
            //Prevent eventhandlers from being called
            this.nudTimer.ValueChanged -= new System.EventHandler(this.nudTimer_ValueChanged);
            this.cbCloseOnAdd.CheckedChanged -= new System.EventHandler(this.cbCloseOnAdd_CheckedChanged);
            this.cbFilter.CheckedChanged -= new System.EventHandler(this.cbFilter_CheckedChanged);
            this.cbMinimizeOnStartup.CheckedChanged -= new System.EventHandler(this.cbMinimizeOnStartup_CheckedChanged);

            cbFilter.Checked = settings.filterOnCombo;
            cbCloseOnAdd.Checked = settings.closeOnAdd;
            nudTimer.Value = settings.minutesTillPopup;
            cbMinimizeOnStartup.Checked = settings.minimizeOnStartup;

            this.nudTimer.ValueChanged += new System.EventHandler(this.nudTimer_ValueChanged);
            this.cbCloseOnAdd.CheckedChanged += new System.EventHandler(this.cbCloseOnAdd_CheckedChanged);
            this.cbFilter.CheckedChanged += new System.EventHandler(this.cbFilter_CheckedChanged);
            this.cbMinimizeOnStartup.CheckedChanged += new System.EventHandler(this.cbMinimizeOnStartup_CheckedChanged);
        }
        public void updateComboBoxSubject()
        {
            //Clear previous
            comboBoxWork.Items.Clear();

            //Filter Settings

            //If project that has been entered before is chosen
            if (comboBoxProject.Items.Contains(comboBoxProject.Text))
            {
                //For all records
                foreach (Record rec in log.records)
                {
                    if (!comboBoxWork.Items.Contains(rec.subject))
                    {
                        bool filter = (rec.projectCode == comboBoxProject.Text);
                        if (!settings.filterOnCombo)
                        {
                            comboBoxWork.Items.Add(rec.subject);
                        }
                        else if (filter)
                        {
                            comboBoxWork.Items.Add(rec.subject);
                        }
                    }
                }
            }
        }
        public void updateTrayIcon()
        {
            trayIcon.Text = "NFH\n" + (settings.minutesTillPopup - minutesPassed) + "m left!";
        }
        public void updateTimePassed()
        {
            //Set time passed in minutes
            textBoxTime.Text = minutesPassed.ToString();
            updateStatus("Time calculated");
        }
        // ----------------- Sets -----------------------------
        public void setUcStatisticslog()
        {
            ucStatistics.setWorklog(log);
        }

        // ------------------ EventHandlers ------------------ 
        #region menustrip
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile.ShowDialog();

            //Only do stuff inside here, otherwise probably crashes is clicked on cancel
            if (newFile.FileName != "")
            {
                //If newfile instead of save as, create new workLog
                if (((ToolStripMenuItem)sender).Name.Contains("new"))
                {
                    this.log = new workLog();
                }
                log.createNew(newFile.FileName);
                settings.lastOpened = openFile.FileName;
                settings.save();

                //Enable buttons etc.
                comboBoxProject.Enabled = true;
                comboBoxWork.Enabled = true;
                textBoxTime.Enabled = true;
                buttonAdd.Enabled = true;
                button_left.Enabled = true;
                button_right.Enabled = true;
                dateTimePicker.Enabled = true;

                updateStatus("File created");
                this.Text = "Never Forget Hydra - " + log.getPath();
                //If new file, popuptimer can be 
                //Incase previous file had records in richtextbox field
                updateRecords();
                setUcStatisticslog();
                popupTimer.Start();
                fileOpen = true;
            }

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(ToolStripMenuItem))
            {
                openFile.ShowDialog();
            } else
            {
                openFile.FileName = settings.lastOpened;
            }

            //openFile.
            //Only do stuff inside here, otherwise probably crashes if clicked on cancel
            if (openFile.FileName != "")
            {
                log = log.load(openFile.FileName);
                updateRecords();
                settings.lastOpened = openFile.FileName;
                settings.save();

                //Enable buttons etc.
                comboBoxProject.Enabled = true;
                comboBoxWork.Enabled = true;
                textBoxTime.Enabled = true;
                buttonAdd.Enabled = true;
                button_left.Enabled = true;
                button_right.Enabled = true;
                dateTimePicker.Enabled = true;

                //pictureBoxLogo.Visible = false;
                //tableLayoutPanel.SetRowSpan(dataGridView, 2);
                updateStatus("File Loaded");
                this.Text = "Never Forget Hydra - " + log.getPath();
                initComboBoxProject();
                setUcStatisticslog();
                popupTimer.Start();
                fileOpen = true;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Before exit, remove trayicon, otherwise it remains for some reason...
            trayIcon.Dispose();

            //Exit application
            Application.Exit();
        }
        private void setColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorc = new ColorDialog();
            colorc.ShowDialog();
            Color test = colorc.Color;
            settings.highlightColor = test.ToArgb();
            settings.save();
            applyTheming();
            applyAddTheming();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form setting = new FormSettings(this, theme, settings);
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (setting.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                //this.txtResult.Text = testDialog.TextBox1.Text;
            }
            setting.Dispose();
        }
        private void hydraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mycloud.barco.com/Citrix/barcoWeb/");
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new FormAbout(theme, settings);
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (about.ShowDialog(this) == DialogResult.OK)
            {
            }
            about.Dispose();
        }
        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form feedback = new FormFeedback(this, theme, settings);
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (feedback.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                //this.txtResult.Text = testDialog.TextBox1.Text;
            }
            feedback.Dispose();
        }
        private void ShowChangelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangelog changes = new FormChangelog(this, theme, settings);
            DialogResult rslt = changes.ShowDialog();
        }
        #endregion

        #region Form
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                trayIcon.Visible = true;
                this.Hide();
                e.Cancel = true;
            }
        }
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            if (settings.minimizeOnStartup == true)
            {
                if (File.Exists(settings.lastOpened))
                {
                    this.Hide();
                    openToolStripMenuItem_Click(sender, e);
                }
            }
        }
        #endregion

        #region Controlbar
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxWork.Text == "" || comboBoxProject.Text == "" || textBoxTime.Text == "")
            {
                DialogResult error = MessageBox.Show("One or more of the required fields is empty.", "Cannot add new record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!short.TryParse(textBoxTime.Text, out short _))
            {
                DialogResult error = MessageBox.Show("Cannot interpret the time value as a number.", "Cannot add new record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Add the record
                log.addRecord(dateTimePicker.Value.Date, comboBoxWork.Text, comboBoxProject.Text, Convert.ToDecimal(textBoxTime.Text));

                //Ui: Add projectcode to comboBox
                if (!comboBoxProject.Items.Contains(comboBoxProject.Text))
                {
                    comboBoxProject.Items.Add(comboBoxProject.Text);
                }

                //Update subjects in comboBox
                updateComboBoxSubject();

                //Update Richtextbox
                updateRecords();

                //Save to XML file
                log.save();
                updateStatus("Records saved");
                //If setting: Close on Add, close form to tray
                if (settings.closeOnAdd)
                {
                    trayIcon.Visible = true;
                    this.Hide();
                }
            }

        }
        private void button_left_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(-1);
        }
        private void button_right_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            updateRecords();
        }
        private void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateComboBoxSubject();
        }
        #endregion

        #region Quicksettings
        private void nudTimer_ValueChanged(object sender, EventArgs e)
        {
            FormSettings parser = new FormSettings(this, theme, settings);
            parser.handlerUpDownChanged(sender, e);
            parser.btnSubmit_Click(sender, e);
            parser.Dispose();
        }
        private void cbCloseOnAdd_CheckedChanged(object sender, EventArgs e)
        {
            FormSettings parser = new FormSettings(this, theme, settings);
            parser.handlerCheckedChanged(sender, e);
            parser.btnSubmit_Click(sender, e);
            parser.Dispose();
        }
        private void cbFilter_CheckedChanged(object sender, EventArgs e)
        {
            FormSettings parser = new FormSettings(this, theme, settings);
            parser.handlerCheckedChanged(sender, e);
            parser.btnSubmit_Click(sender, e);
            parser.Dispose();
        }
        private void cbDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            FormSettings parser = new FormSettings(this, theme, settings);
            parser.handlerCheckedChanged(sender, e);
            parser.btnSubmit_Click(sender, e);
            parser.Dispose();
        }
        private void cbMinimizeOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            FormSettings parser = new FormSettings(this, theme, settings);
            parser.handlerCheckedChanged(sender, e);
            parser.btnSubmit_Click(sender, e);
            parser.Dispose();
        }
        private void btnResetTimer_Click(object sender, EventArgs e)
        {
            if (fileOpen)
            {
                minutesPassed = 0;
                updateTrayIcon();
                updateStatus("Popup timer reset");
            }
        }
        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            // Hide records View, show statistics
            if (view == View.records)
            {
                tlpWorkspace.Controls.Remove(dataGridView);
                tlpWorkspace.Controls.Add(ucStatistics, 1, 0);

                // To ensure datagrid is themed at start
                // Perhaps there's a better location for this
                applyAddTheming();
            }
            view = View.statistics;
        }
        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            // Hide statistics, show records view
            if (view == View.statistics)
            {
                tlpWorkspace.Controls.Remove(ucStatistics);
                tlpWorkspace.Controls.Add(dataGridView, 1, 0);
            }
            view = View.records;
            // ((UcWorkloadChart)tlpWorkspace.Controls.Find("stats", false)[0]).Dispose();            
        }
        #endregion

        #region Other
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if delete is pressed
            if (e.ColumnIndex == 4)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (confirm == DialogResult.Yes)
                {
                    //Delete record that matches the selected row
                    log.removeRecord(dateTimePicker.Value.Date, dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                    log.save();
                    updateRecords();
                }
                //(e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
            }
        }
        private void trayIcon_DoubleClick(object Sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.
            this.Show();
            // Calculate and fill in time passed since last timer popup
            updateTimePassed();
            // Activate the form.
            this.Activate();
        }
        private void comboBoxWork_KeyDown(object sender, KeyEventArgs e)
        {
            //If in comboBoxWork and enter is pressed, simulate add button
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.PerformClick();
            }
        }
        #endregion
    }
}
