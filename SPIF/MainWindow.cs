using CMDT;
using SPIF;
using CMIF;
using SPDT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using CMLO;

namespace SPIF
{
    public partial class MainWindow : ThemedForm
    {
        // ---------- Globals

        // Datagrid view column names
        internal const string COLUMN_NAME_DATE = "Date";
        internal const string COLUMN_NAME_COSTCENTER = "Cost C.";
        internal const string COLUMN_NAME_PROJECT = "Project";
        internal const string COLUMN_NAME_SUBJECT = "Subject";
        internal const string COLUMN_NAME_TIME = "Time";
        internal const string COLUMN_NAME_DELETE = "Remove";

        // Colors
        internal Color HELPCOLOR = Color.FromArgb(0, 125, 255);

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
        private WinForm_SelfdestructStatus helpStatus;

        //Create system Tray Icon
        private NotifyIcon trayIcon;
        private ContextMenu trayIcon_cmenu;

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
            cbSubject.DroppedDown = true;
        }
        // ------------------ Themes and color ------------------
        // Main theming happens in derrived class: ThemedForm
        // Additional theming here
        public void applyAddTheming()
        {
            //Add button specific
            btnAdd.BackColor = theme.textHighlight;
            btnAdd.ForeColor = theme.highlight;

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
            btnFold.BackColor = theme.highlight;
            btnFold.ForeColor = theme.text;
            btnFold.FlatAppearance.BorderSize = 0;

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
            cbProject.Items.Clear();

            foreach (Record rec in log.records)
            {
                if (!cbProject.Items.Contains(rec.project))
                {
                    //When pressing add, new project code needs to be added directly if not yet in it!
                    //Calling this method is to much overhead
                    cbProject.Items.Add(rec.project);
                }
            }
        }
        private void initComboBoxCostCenter()
        {
            cbCostCenter.Items.Clear();

            foreach (Record rec in log.records)
            {
                if (!cbCostCenter.Items.Contains(rec.costCenter))
                {
                    //When pressing add, new project code needs to be added directly if not yet in it!
                    //Calling this method is to much overhead
                    cbCostCenter.Items.Add(rec.costCenter);
                }
            }
        }
        private void initTrayIcon()
        {
            trayIcon = new NotifyIcon();
            trayIcon.Icon = SPIF.Properties.Resources.Hourglass;
            updateTrayIcon();   // Hover text
            trayIcon.Visible = true;

            trayIcon_cmenu = new ContextMenu();
            trayIcon_cmenu.MenuItems.Add(0, new MenuItem("Show", new EventHandler(TrayIcon_Cmenu_Show_Click)));
            trayIcon_cmenu.MenuItems.Add(1, new MenuItem("Settings", settingsToolStripMenuItem_Click));
            trayIcon_cmenu.MenuItems.Add(2, new MenuItem("Exit", exitToolStripMenuItem_Click));
            trayIcon.ContextMenu = trayIcon_cmenu;

            // Handle the DoubleClick event to activate the form.
            trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
        }
        private void TrayIcon_Cmenu_Show_Click(object sender, EventArgs e)
        {
            popup();
        }
        private void initUcStatistics()
        {
            ucStatistics = new UcStatistics(ref theme, ref log);
        }

        // ------------------ Updates-------- ------------------
        // Reminder: Every update should be public and designed in such a way that this is allowed.
        public void updateRecords()
        {
            //Clear datagrid
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            //Add Columns
            dataGridView.Columns.Add(COLUMN_NAME_DATE, COLUMN_NAME_DATE);
            dataGridView.Columns.Add(COLUMN_NAME_COSTCENTER, COLUMN_NAME_COSTCENTER);
            dataGridView.Columns.Add(COLUMN_NAME_PROJECT, COLUMN_NAME_PROJECT);
            dataGridView.Columns.Add(COLUMN_NAME_TIME, COLUMN_NAME_TIME);
            dataGridView.Columns.Add(COLUMN_NAME_SUBJECT, COLUMN_NAME_SUBJECT);
            dataGridView.Columns.Add(COLUMN_NAME_DELETE, "");

            //Set Column settings
            foreach (DataGridViewColumn dc in dataGridView.Columns)
            {
                dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Subject column should be biggest, others just min size
            dataGridView.Columns[COLUMN_NAME_SUBJECT].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Add the data
            List<Record> records = log.getRecordsByDate(dateTimePicker.Value.Date);

            foreach (Record rec in records)
            {
                int rowId = dataGridView.Rows.Add();

                // Grab the new row!
                DataGridViewRow row = dataGridView.Rows[rowId];
                row.Cells[COLUMN_NAME_DATE].Value = rec.recordDate.ToShortDateString();
                row.Cells[COLUMN_NAME_COSTCENTER].Value = rec.costCenter;
                row.Cells[COLUMN_NAME_PROJECT].Value = rec.project;
                row.Cells[COLUMN_NAME_TIME].Value = rec.minutes.ToString();
                row.Cells[COLUMN_NAME_SUBJECT].Value = rec.subject;
                row.Cells[COLUMN_NAME_DELETE].Value = "Delete";
                //Possible to change colour based on time value, but it ugly:
                //row.Cells["Time"].Style.BackColor = Color.FromArgb((int)rec.minutes, (int)rec.minutes, (int)rec.minutes);
            }
        }
        public void updateStatus(string text)
        {
            _ = new WinForm_SelfdestructStatus(ref statusStrip, text, 5, theme.textHighlight, theme.highlight);
        }
        public void updateStatus(string text, decimal seconds, Color back)
        {
            _ = new WinForm_SelfdestructStatus(ref statusStrip, text, seconds, theme.textHighlight, back);
        }
        public void updateHelpStatus(string text)
        {
            // Destroy if still exists for some reason.
            if (helpStatus != null)
            {
                helpStatus.destructStatus();
            }

            // Create helpstatus
            helpStatus = new WinForm_SelfdestructStatus(ref statusStrip, text, Color.White, HELPCOLOR);
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
            cbSubject.Items.Clear();
            //If project that has been entered before is chosen
            if (cbProject.Items.Contains(cbProject.Text))
            {
                //For all records
                foreach (Record rec in log.records)
                {
                    if (!cbSubject.Items.Contains(rec.subject))
                    {
                        bool filter = (rec.project == cbProject.Text);
                        if (!settings.filterOnCombo)
                        {
                            cbSubject.Items.Add(rec.subject);
                        }
                        else if (filter)
                        {
                            cbSubject.Items.Add(rec.subject);
                        }
                    }
                }
            }
        }
        public void updateComboBoxProject()
        {
            //Clear previous
            cbProject.Items.Clear();
            //If project that has been entered before is chosen
            if (cbCostCenter.Items.Contains(cbCostCenter.Text))
            {
                //For all records
                foreach (Record rec in log.records)
                {
                    if (!cbProject.Items.Contains(rec.project))
                    {
                        bool filter = (rec.costCenter == cbCostCenter.Text);
                        if (!settings.filterOnCombo)
                        {
                            cbProject.Items.Add(rec.project);
                        }
                        else if (filter)
                        {
                            cbProject.Items.Add(rec.project);
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
            tbTime.Text = minutesPassed.ToString();
            updateStatus("Time calculated");
        }
        // ------------------ EventHandlers ------------------ 
        #region menustrip
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile.ShowDialog();

            //Only do stuff inside here, otherwise probably crashes is clicked on cancel
            if (!Generic.isNullOrEmpty(newFile.FileName))
            {
                //If newfile instead of save as, create new workLog
                if (((ToolStripMenuItem)sender).Name.Contains("new"))
                {
                    this.log = new workLog();
                    ucStatistics.setLog(ref log);
                }
                log.createNew(newFile.FileName);
                settings.lastOpened = openFile.FileName;
                settings.save();

                //Enable buttons etc.
                cbCostCenter.Enabled = true;
                cbProject.Enabled = true;
                cbSubject.Enabled = true;
                tbTime.Enabled = true;
                btnAdd.Enabled = true;
                button_left.Enabled = true;
                button_right.Enabled = true;
                dateTimePicker.Enabled = true;


                updateStatus("File created");
                this.Text = "Never Forget Hydra - " + log.getPath();
                //If new file, popuptimer can be 
                //Incase previous file had records in richtextbox field
                updateRecords();
                
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
            if (!Generic.isNullOrEmpty(openFile.FileName))
            {
                log = log.load(openFile.FileName);
                ucStatistics.setLog(ref log);
                updateRecords();
                settings.lastOpened = openFile.FileName;
                settings.save();

                //Enable buttons etc.
                cbCostCenter.Enabled = true;
                cbProject.Enabled = true;
                cbSubject.Enabled = true;
                tbTime.Enabled = true;
                btnAdd.Enabled = true;
                button_left.Enabled = true;
                button_right.Enabled = true;
                dateTimePicker.Enabled = true;

                //pictureBoxLogo.Visible = false;
                //tableLayoutPanel.SetRowSpan(dataGridView, 2);
                updateStatus("File Loaded");
                this.Text = "Never Forget Hydra - " + log.getPath();
                initComboBoxCostCenter();
                initComboBoxProject();
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
            FormChangelog changes = new FormChangelog(theme, settings);
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
            if (Generic.isNullOrEmpty(cbCostCenter.Text) || Generic.isNullOrEmpty(cbSubject.Text) || Generic.isNullOrEmpty(cbProject.Text) || Generic.isNullOrEmpty(tbTime.Text))
            {
                DialogResult error = MessageBox.Show("One or more of the required fields is empty.", "Cannot add new record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!short.TryParse(tbTime.Text, out short _))
            {
                DialogResult error = MessageBox.Show("Cannot interpret the time value as a number.", "Cannot add new record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Add the record
                log.addRecord(dateTimePicker.Value.Date, cbCostCenter.Text, cbProject.Text, cbSubject.Text, Convert.ToDecimal(tbTime.Text));

                //Ui: Add costCenter to comboBox
                if (!cbCostCenter.Items.Contains(cbCostCenter.Text))
                {
                    cbCostCenter.Items.Add(cbCostCenter.Text);
                }


                //Update subjects in comboBox
                updateComboBoxProject();
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
        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubject.SelectedIndex = -1;
            updateComboBoxSubject();
        }
        private void cbCostCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProject.SelectedIndex = -1;
            updateComboBoxProject();
            
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
                tlpWorkspace.Controls.Add(ucStatistics, 2, 0);

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
                tlpWorkspace.Controls.Add(dataGridView, 2, 0);
            }
            view = View.records;
            // ((UcWorkloadChart)tlpWorkspace.Controls.Find("stats", false)[0]).Dispose();            
        }
        private void btnFold_Click(object sender, EventArgs e)
        {
            CheckBox fake = new CheckBox();
            fake.Checked = !settings.showQuickSettings;
            fake.Name = "cbShowQuickSettings";

            FormSettings parser = new FormSettings(this, theme, settings);
            parser.handlerCheckedChanged(fake, e);
            parser.btnSubmit_Click(sender, e);
            parser.Dispose();
        }
        #endregion

        #region Other
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if delete is pressed
            if (e.ColumnIndex == dataGridView.Columns[COLUMN_NAME_DELETE].Index)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (confirm == DialogResult.Yes)
                {
                    //Delete record that matches the selected row
                    string costCenter = dataGridView.Rows[e.RowIndex].Cells[COLUMN_NAME_COSTCENTER].Value.ToString();
                    string column = dataGridView.Rows[e.RowIndex].Cells[COLUMN_NAME_PROJECT].Value.ToString();
                    string subject = dataGridView.Rows[e.RowIndex].Cells[COLUMN_NAME_SUBJECT].Value.ToString();

                    log.removeRecord(dateTimePicker.Value.Date, costCenter , column, subject);
                    log.save();

                    updateRecords();
                }
                //(e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
            }
        }
        private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // If first and last cell selected is in minutes column
            if (dataGridView.SelectedCells[0].ColumnIndex == dataGridView.Columns[COLUMN_NAME_TIME].Index && dataGridView.SelectedCells[dataGridView.SelectedCells.Count - 1].ColumnIndex == dataGridView.Columns[COLUMN_NAME_TIME].Index && dataGridView.SelectedCells.Count > 1)
            {
                decimal selectedMin = 0;
                foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                {

                    selectedMin += Int16.Parse(cell.Value.ToString(), CultureInfo.InvariantCulture);
                }
                //MessageBox.Show("Total minutes is: " + selectedMin.ToString(), "Sum", MessageBoxButtons.OK);
                updateStatus("Sum of minutes: " + Generic.convertMinutesToHoursString(selectedMin));
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
                btnAdd.PerformClick();
            }
        }
        #endregion

        private void tbTime_Enter(object sender, EventArgs e)
        {
            // Upon focus
            updateHelpStatus("Fill in: Spent Time");
        }
        private void cbCostCenter_Enter(object sender, EventArgs e)
        {
            // Upon focus
            updateHelpStatus("Fill in: Cost Center");
        }
        private void cbProject_Enter(object sender, EventArgs e)
        {
            // Upon focus
            updateHelpStatus("Fill in: Project");
        }
        private void cbSubject_Enter(object sender, EventArgs e)
        {
            // Upon focus
            updateHelpStatus("Fill in: Subject");
        }

        // Destroy helpStatus when out of focus
        private void tbTime_Leave(object sender, EventArgs e)
        {
            helpStatus.destructStatus();
        }
        private void cbCostCenter_Leave(object sender, EventArgs e)
        {
            helpStatus.destructStatus();
        }
        private void cbProject_Leave(object sender, EventArgs e)
        {
            helpStatus.destructStatus();
        }
        private void cbSubject_Leave(object sender, EventArgs e)
        {
            helpStatus.destructStatus();
        }


    }
}
