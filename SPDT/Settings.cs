using CMDA;
using CMDT;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDT
{
    [Serializable]
    public class Settings
    {
        //Settings
        public int settingsVersionNumber = 2;

        //Checkbox
        public bool filterOnCombo { get; set; } = false;
        public bool closeOnAdd { get; set; } = false;
        public bool minimizeOnStartup { get; set; } = false;
        public bool showJokes { get; set; } = false;
        public bool showQuickSettings { get; set; } = true;

        //Up down
        public decimal minutesTillPopup { get; set; } = 30;

        //Custom
        public Theme.themeStyle style { get; set; } = Theme.themeStyle.light;
        public int highlightColor { get; set; } = Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))).ToArgb();
        public string lastOpened { get; set; } = "";


        //Other variables, no settings
        private string path = AppDomain.CurrentDomain.BaseDirectory + "/nfhSettings.xml";

        public Settings load()
        {
            FileInfo file = new FileInfo(path);
            if (!file.Exists)
            {
                save();
            }
            IoXml xmlReader = new IoXml();
            return (Settings)(xmlReader.loadXml(GetType(), path));
        }
        public void save()
        {
            IoXml xmlReader = new IoXml();
            xmlReader.saveXml(this, GetType(), path);
        }
    }
}
