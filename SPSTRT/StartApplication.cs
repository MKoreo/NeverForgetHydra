using SPDT;
using SPIF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPSTRT
{
    public class StartApplication
    {
        public void Start()
        {
            //This is a starter project to enable updating DLLs
            //This one will never change and will be locked upon starting NeverForgetHydra.exe
            //Other DLL's will only be used when this one is called and can thus be updated
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //Start main
            //Load settings first as it also contains theme related stuff and we want all windows to point to its location
            Settings settings = new Settings();
            settings = settings.load();

            FormMain main = new FormMain(settings);
            Application.Run(main);
        }
    }
}