using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NeverForgetHydra
{
    static class Start
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Some specific Application settings
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Check for updates/Files & dispose
            _ = new FormUpdate();

            //Use starter project to start Never Forget Hydra's app
            SPSTRT.StartApplication app = new SPSTRT.StartApplication();
            app.Start();
        }
    }
}
