using SPDT;
using SPIF;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SPSTRT
{
    public class StartApplication
    {
        public void Start()
        {
            //This is a starter project to allow updating DLLs by preventing to lock them when running the .exe
            //This one will never change and will be locked upon starting NeverForgetHydra.exe

            //When running without debugger, exceptions in application will be handler by automatic handler.
            //To prevent that, handle thread exceptions and unhandled ones.
            AppDomain.CurrentDomain.UnhandledException += this.CurrentDomain_UnhandledExceptiond;
            Application.ThreadException += ThreadExceptionHandler;

            //Load settings first as it also contains theme related stuff and we want all windows to point to its location
            Settings settings = new Settings();
            settings = settings.load();   
            
            //Start main window
            FormMain main = new FormMain(settings);
            Application.Run(main);
        }

        private void CurrentDomain_UnhandledExceptiond(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                //Send exception as feedback before restarting
                Exception exception = (Exception)e.ExceptionObject;
                sendFeedback(exception.ToString());
                MessageBox.Show("NFH crashed unexpectedly! Feedback has been sent! \nRestarting...", "NFH Crashed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
                Environment.Exit(0);
            } catch (Exception ex)
            {
                //Incase feedback would still contain illigal chars or no internet connection is available.
                MessageBox.Show("NFH crashed unexpectedly! Feedback could not be sent! \nRestarting...", "NFH Crashed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
                Environment.Exit(0);
            }

        }

        private void ThreadExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                //Send exception as feedback before restarting
                Exception exception = e.Exception;
                sendFeedback(exception.ToString());
                MessageBox.Show("NFH crashed unexpectedly! Feedback has been sent! \nIt will now attempt to restart...", "NFH Crashed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                //Incase feedback would still contain illigal chars or no internet connection is available.
                MessageBox.Show("NFH crashed unexpectedly! Feedback could not be sent! \nRestarting...", "NFH Crashed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
                Environment.Exit(0);
            }
        }

        public void sendFeedback(string feedback)
        {
            //Send automated feedback using FormFeedback, with empty constructor
            FormFeedback parser = new FormFeedback();
            parser.feedback = feedback;
            parser.sendFeedback();
            parser.Dispose();
        }
    }
}