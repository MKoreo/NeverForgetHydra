using System;
using System.Diagnostics;
using System.Linq;
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

            // Kill other process
            //bool alreadyRunning = Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1;
            //if (alreadyRunning)
            //{
            //    Process.killGetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).;
            //}

            // Update class
            Updater update = new Updater(); //Will block thread untill done
            update = null;

            //Check for updates/Files & dispose
            //_ = new FormUpdate();

            //Use starter project to start Never Forget Hydra's app
            SPSTRT.StartApplication app = new SPSTRT.StartApplication();
            app.Start();
        }
    }
}
