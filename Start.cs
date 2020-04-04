using System;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormUpdate updater = new FormUpdate();

            //Code that checks versions
            //DialogResult dialogResult = updater.ShowDialog();
            //If up to date, launch by calling new proj start that contains references to other dlls
            //this one only references this reference DLL
            try
            {
                SPSTRT.StartApplication app = new SPSTRT.StartApplication();
                app.Start();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Something went wrong while starting NFH", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
