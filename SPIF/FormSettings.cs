using CMDT;
using CMIF;
using CMLO;
using SPDT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPIF
{
    public partial class FormSettings : ThemedForm
    {
        private MainWindow parent;
        public FormSettings(MainWindow parent, Theme theme, ref Settings settings) : base(ref settings)
        {
            InitializeComponent();

            this.parent = parent;
            this.theme = theme;
            // this.settings = settings;

            applyTheming();
            applyAddTheming();

            //load setting values into gui
            initializeGui();
        }

        public FormSettings(MainWindow parent, Settings settings) : base(ref settings)
        {
            this.parent = parent;
            //this.settings = settings;
        }

        private void initializeGui()
        {
            //Change init state depending on settingsfile
            cbShowQuickSettings.Checked = settings.showQuickSettings;
            cbCloseOnAdd.Checked = settings.closeOnAdd;
            cbFilter.Checked = settings.filterOnCombo;
            cbMinimizeOnStartup.Checked = settings.minimizeOnStartup;
            cbShowJokes.Checked = settings.showJokes;
            cbDarkTheme.Checked = (settings.style == Theme.themeStyle.dark ? true : false);
            
            //Numeric Up down
            nudTimer.Value = settings.minutesTillPopup;

            //Set handlers active
            //Checkboxes
            this.cbCloseOnAdd.CheckedChanged += new EventHandler(this.handlerCheckedChanged);
            this.cbFilter.CheckedChanged += new EventHandler(this.handlerCheckedChanged);
            this.cbShowQuickSettings.CheckedChanged += new EventHandler(this.handlerCheckedChanged);
            this.cbMinimizeOnStartup.CheckedChanged += new EventHandler(this.handlerCheckedChanged);
            this.cbShowJokes.CheckedChanged += new EventHandler(this.handlerCheckedChanged);
            this.cbDarkTheme.CheckedChanged += new EventHandler(this.handlerCheckedChanged);

            //Values
            this.nudTimer.ValueChanged += new EventHandler(this.handlerUpDownChanged);
        }
        private void applyAddTheming()
        {
            //Specific
            //Add button specific
            btnSubmit.BackColor = theme.highlight;
            btnSubmit.ForeColor = theme.text;

            lblTitel.BackColor = theme.tint1;
            lblTitel.ForeColor = theme.text;
            //Update Window
            this.Invalidate();
        }

        //Public cause quicksettings from main can call this
        public void handlerCheckedChanged(object obj, EventArgs args)
        {
            switch (((CheckBox)obj).Name)
            {
                case "cbCloseOnAdd":
                    settings.closeOnAdd = ((CheckBox)obj).Checked;
                    break;
                case "cbFilter":
                    settings.filterOnCombo = ((CheckBox)obj).Checked;
                    parent.updateComboBoxProject();
                    parent.updateComboBoxSubject();
                    break;
                case "cbShowJokes":
                    settings.showJokes = cbShowJokes.Checked;
                    break;
                case "cbShowQuickSettings":
                    settings.showQuickSettings = ((CheckBox)obj).Checked;
                    if (!settings.showQuickSettings)
                    {
                        parent.tableLayoutPanelSettings.Visible = false;
                        parent.tlpWorkspace.ColumnStyles[1].Width = 0;
                    } else
                    {
                        parent.tableLayoutPanelSettings.Visible = true;
                        parent.tlpWorkspace.ColumnStyles[1].Width = 230;
                    }
                    break;
                case "cbMinimizeOnStartup":
                    settings.minimizeOnStartup = ((CheckBox)obj).Checked;
                    if (settings.minimizeOnStartup == true)
                    {
                        //If not in startup, add it
                        if (!WindowsSpecific.checkForStartup("NeverForgetHydra"))
                        {
                            WindowsSpecific.addToStartup("NeverForgetHydra", Assembly.GetEntryAssembly().Location);
                        }
                    }
                    else //if settings.minimizedStartup == false
                    {
                        //If in startup, remove it
                        if (WindowsSpecific.checkForStartup("NeverForgetHydra"))
                        {
                            WindowsSpecific.removeFromStartup("NeverForgetHydra");
                        }
                    }
                    break;
                case "cbDarkTheme":
                    if (((CheckBox)obj).Checked)
                    {
                        settings.style = Theme.themeStyle.dark;
                    }
                    else
                    {
                        settings.style = Theme.themeStyle.light;
                    }
                    parent.applyTheming();
                    parent.applyAddTheming();
                    this.applyTheming();
                    this.applyAddTheming();
                    break;
                default:
                    MessageBox.Show("Error: Not Implemented", "Oh noes, an error has occured. It's probably your fault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }


        //Public cause quicksettings from main can call this
        public void handlerUpDownChanged(object obj, EventArgs args)
        {
            switch (((NumericUpDown)obj).Name)
            {
                case "nudTimer":
                    settings.minutesTillPopup = ((NumericUpDown)obj).Value;
                    parent.updateTrayIcon();
                    break;
                default:
                    MessageBox.Show("Error: Not Implemented", "Oh noes, an error has occured. It's probably your fault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }
        public void btnSubmit_Click(object sender, EventArgs e)
        {
            settings.save();
            parent.updateQuickSettings();
            parent.updateStatus("Settings saved");
            this.Close();
        }
    }
}