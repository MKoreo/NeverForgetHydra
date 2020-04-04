using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeverForgetHydra
{
    public partial class FormUpdate : Form
    {
        //Links to Google Drive: A Version.ini file and a zip containing the newest DLL files
        const string LINKTOZIP = "https://drive.google.com/u/0/uc?id=141X9ebxs3Y87P68wi6JNGXH8o3jWDEKr&export=download";
        const string LINKTOVER = "https://drive.google.com/u/0/uc?id=1oOYv15NwKKk6SuFhsFzdehTvw_T87X6Z&export=download";
        List<string> dllToCheck = new List<string>();

        //Background workers for simultanous file checking, version checking and afterwards updating
        private BackgroundWorker bwFileChecker = new BackgroundWorker();
        private BackgroundWorker bwVersionChecker = new BackgroundWorker();
        private BackgroundWorker bwUpdater = new BackgroundWorker();

        //Checking for updates done
        private bool done = false;

        //Startfase
        private MessageBoxButtons choice = MessageBoxButtons.AbortRetryIgnore;
        private AutoResetEvent _fileCheckComplete = new AutoResetEvent(false);

        public FormUpdate()
        {
            InitializeComponent();

            //Which files should be present
            dllToCheck.Add("CMDA.dll");
            dllToCheck.Add("CMDT.dll");
            dllToCheck.Add("CMIF.dll");
            dllToCheck.Add("CMLO.dll");
            //compareDll.Add("SPDA.dll");
            dllToCheck.Add("SPDT.dll");
            dllToCheck.Add("SPIF.dll");
            //compareDll.Add("SPLO.dll");

            // FileChecker setup
            // Check Files are present
            bwFileChecker.DoWork += work_checkFiles;
            bwFileChecker.RunWorkerAsync();

            // Check version file on Google drive and compare with local file.
            bwVersionChecker.DoWork += work_checkVersion;
            bwVersionChecker.WorkerSupportsCancellation = true;
            bwVersionChecker.RunWorkerAsync();

            //Update files
            bwUpdater.DoWork += work_UpdateVersion;

            while (!done)
            {
                Thread.Sleep(100);
            }
            this.Close();
        }

        private void work_UpdateVersion(object sender, DoWorkEventArgs e)
        {
            try {
                using (var client = new WebClient())
                {
                    client.DownloadFile(LINKTOZIP, "NFH_update.zip");
                }
                foreach (string fileName in dllToCheck)
                {
                    File.Delete(fileName);
                }

                ZipFile.ExtractToDirectory("NFH_update.zip", ".\\");
                File.Delete("NFH_update.zip");
                done = true;
            } catch (Exception updateException)
            {
                if (updateException is WebException)
                {
                    MessageBox.Show("Failed to download update. Please check your internet connection.", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show(updateException.ToString(), "Update failed", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void work_checkFiles(object sender, DoWorkEventArgs e)
        {
            try
            {
                //Get all DLL files next to .exe
                string[] dll = Directory.GetFileSystemEntries(Directory.GetCurrentDirectory(), "*.dll");
                //To Keep track of missing DLL files
                List<string> missingDll = new List<string>();

                foreach (string cmp in dllToCheck)
                {
                    if (!(dll.Contains(Directory.GetCurrentDirectory() + "\\" + cmp)))
                    {
                        missingDll.Add(cmp);
                    }
                }

                if (missingDll.Count() > 0)
                {
                    string faultMessage = "";
                    foreach (string str in missingDll)
                    {
                        faultMessage += " " + str + ",";
                    }
                    faultMessage = faultMessage.TrimEnd(',');
                    bwVersionChecker.CancelAsync();
                    DialogResult result = MessageBox.Show("Following files are missing:" + faultMessage + "\nThey will be downloaded if an internet connection is available.", "Never Forget Hydra - Missing Files", MessageBoxButtons.OK);
                    //Stop Checking version and just update.
                    bwUpdater.RunWorkerAsync();
                }
                else
                {
                    _fileCheckComplete.Set();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "File Checking failed", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void work_checkVersion(object sender, DoWorkEventArgs e)
        {
            try
            {
                //Download Version.ini
                using (var client = new WebClient())
                {
                    client.DownloadFile(LINKTOVER, "version.ini");
                }

                //Get all lines from file and turn values into sepperate strings
                string[] lines = System.IO.File.ReadAllLines(@"version.ini");
                string[] version = lines[0].Substring(lines[0].IndexOf("20")).TrimEnd(' ').Split('.'); //Removes "* Version: "
                //Only continue if we know the file is there
                _fileCheckComplete.WaitOne();
                //Get program version
                string[] versionCmp = FileVersionInfo.GetVersionInfo(@"SPIF.dll").FileVersion.Split('.');

                //To make sure both files use same format, remove prefix 0's but not for last as that is just an index
                for (int l = 0; l < version.Count() - 2; l++)
                {
                    if (!short.TryParse(version[l], out short _dump))
                    {
                        version[l] = "0";
                    } else
                    {
                        version[l] = version[l].TrimStart('0');
                    }
                }
                for (int l = 0; l < version.Count() - 2; l++)
                {
                    versionCmp[l] = versionCmp[l].TrimStart('0');
                }

                DateTime ver = new DateTime(short.Parse(version[0]), short.Parse(version[1]), short.Parse(version[2]));
                DateTime verCmp = new DateTime(short.Parse(versionCmp[0]), short.Parse(versionCmp[1]), short.Parse(versionCmp[2]));
                int daysBetweenDates = (int)Math.Round((ver - verCmp).TotalDays, 0);
                if ((daysBetweenDates == 0 && version[3] == versionCmp[3]) || (daysBetweenDates < 0))
                {
                    //Up to date: Do nothing
                    done = true;
                    bwVersionChecker.CancelAsync();
                }
                else if (daysBetweenDates > 0 && daysBetweenDates <= 7)
                {
                    //Mild out of date: Give option
                    choice = MessageBoxButtons.OKCancel;
                }
                else if (daysBetweenDates > 7 || (daysBetweenDates <= 0 && version[3] != versionCmp[3]))
                {
                    //Out of date or hotfix: Update anyway
                    choice = MessageBoxButtons.OK;
                }

                if (bwVersionChecker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                string versionInfo = "";
                int i = 1;
                while (i < lines.Count() - 1)
                {
                    string buffer = lines[i];
                    buffer = buffer.Trim();
                    if (buffer == "")
                    {
                        break;
                    }
                    else
                    {
                        versionInfo += (buffer + "\n");
                    }

                    i++;
                }
                FormChangelog change = new FormChangelog(lines, choice);

                if (DialogResult.Cancel != change.ShowDialog())
                {
                    //Perform updates
                    bwUpdater.RunWorkerAsync();
                }
                else
                {
                    done = true;
                    bwVersionChecker.CancelAsync();
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException && _fileCheckComplete.WaitOne())
                {
                    //Just continue
                    done = true;

                }
                else
                {
                    MessageBox.Show(ex.ToString(), "Failed to check version", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }

        }
    }
}
